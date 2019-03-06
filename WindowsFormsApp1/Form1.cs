using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using NPOI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

               
        /// <summary>
        /// 定义结构类型，用来存放“打开文件”对话框选择的所有文件“试卷”文件与“试卷答案”文件的对应文件位置。
        /// </summary>
        struct exam
        {
            public string 试卷;
            public string 答案;
        };

        /// <summary>
        /// 自己定义的变量
        /// </summary>
        private string[] fileNames;     //存放 源文件 文本框 的“浏览”按钮打开的所有文件名
        System.Collections.Generic.List<exam> examItems = new List<exam>();  //集合类list类型
        //填空题变量：包含题目文件名、答案文件名
        exam fillInExam = new exam();
        //选择题变量：包含题目文件名、答案文件名
        exam choiceExam = new exam();
        //判断题变量：包含题目文件名、答案文件名
        exam trueOrFalseExam = new exam();
        //计算题变量：包含题目文件名、答案文件名
        exam calculationExam = new exam();

        /// <summary>
        /// 源文件 文本框 的浏览按钮的处理函数
        /// 选择文件名时，将试卷和答案全部都选择。
        /// 要求：试卷名和答案名有一定要求 （答案名=试卷名+ 答案）
        ///      如：试卷名： 试卷A.doc
        ///          答案名： 试卷A答案.doc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSourceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件（*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] names = fileDialog.FileNames;
                //txtSourceFile.Text = names[0];

                fileNames = names;   //将选择的文件名，赋给Form1对象的全局变量fileNames
                //foreach (string name in fileNames)
                //{
                //    textBox1.Text += name + "\r\n";
                //}

                Array.Sort(fileNames);  //排序数组元素
                examItems.Clear();    // 删除列表中所有元素。
                
                //将选择的文件按照试卷与答案对应，存入对应的数据结构中
                for (int i = 0; i < fileNames.Length; i += 2)
                {
                    examItems.Add(new exam { 试卷 = fileNames[i], 答案 = fileNames[i + 1] });
                    //textBox1.Text += fileNames[i] + "\r\n";
                    //textBox1.Text += fileNames[i + 1] + "\r\n\r\n";
                }

                txtSourceFile.Text = "";       //将打开文件文本框内容设为空
                //textBox1.Text += "\r\n\r\n  集合类型的数据为：\r\n";
                foreach (var Item in examItems)
                {
                    txtSourceFile.Text += Item.试卷 + "\r\n";
                    txtSourceFile.Text += Item.答案 + "\r\n\r\n";
                }

            }

        }

        /// <summary>
        /// 填空题 文本框 的浏览按钮的处理函数
        /// 选择文件名时，只需要选择 填空题 的文件名（不需要选 填空题答案 的文件名）
        /// 填空题答案 的文件名是由程序自己产生 （在填空题后面加上答案 两个字）。
        /// 要求：要求 （填空题答案名=填空题名+ 答案）
        ///      如：试卷名： 填空题.doc
        ///          答案名： 填空题答案.doc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFillIn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件（*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] names = fileDialog.FileNames;
                //txtFillIn.Text = names[0];

                string text = names[0];
                //文本框显示选择的文件名
                txtFillIn.Text = text + "\r\n";
                fillInExam.试卷 = text;            //将“试卷”文件名保存到填空题变量中
                // 在文件名后面添加“答案”两个字
                var pos = text.IndexOf(".");
                //textBox1.Text = pos.ToString();
                text = text.Insert(pos, "答案");
                fillInExam.答案 = text;            //将“试卷答案”文件名保存到填空题变量中
                txtFillIn.Text += text;

            }
        }

        private void btChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件（*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] names = fileDialog.FileNames;
                //txtChoice.Text = names[0];
                string text = names[0];
                //文本框显示选择的文件名
                txtChoice.Text = text + "\r\n";
                choiceExam.试卷 = text;               ////将“试卷”文件名保存到选择题变量中
                // 在文件名后面添加“答案”两个字
                var pos = text.IndexOf(".");
                //textBox1.Text = pos.ToString();
                text = text.Insert(pos, "答案");
                choiceExam.答案 = text;                ////将“试卷答案”文件名保存到选择题变量中
                txtChoice.Text += text;
            }
        }

        private void btTrueOrFalse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件（*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] names = fileDialog.FileNames;
                //txtTrueOrFalse.Text = names[0];
                string text = names[0];
                //文本框显示选择的文件名
                txtTrueOrFalse.Text = text + "\r\n";
                trueOrFalseExam.试卷 = text;         //将“试卷”文件名保存到判断题变量中
                // 在文件名后面添加“答案”两个字
                var pos = text.IndexOf(".");
                //textBox1.Text = pos.ToString();
                text = text.Insert(pos, "答案");
                trueOrFalseExam.答案 = text;        //将“试卷答案”文件名保存到判断题变量中
                txtTrueOrFalse.Text += text;
            }
        }

        private void btCalculation_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件（*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] names = fileDialog.FileNames;
                //txtCalculation.Text = names[0];
                string text = names[0];
                //文本框显示选择的文件名
                txtCalculation.Text = text + "\r\n";
                calculationExam.试卷 = text;         //将“试卷”文件名保存到计算题变量中
                // 在文件名后面添加“答案”两个字
                var pos = text.IndexOf(".");
                //textBox1.Text = pos.ToString();
                text = text.Insert(pos, "答案");
                calculationExam.答案 = text;        //将“试卷答案”文件名保存到计算题变量中
                txtCalculation.Text += text;

            }
        }

        /// <summary>
        /// 按word文件的页，来提取每一页的内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSplitFile_Click(object sender, EventArgs e)
        {
            //打开要提取的试卷文件
            var app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = true;

            foreach(var item in examItems)
            {
                var doc = app.Documents.Open(item.试卷);

                ///////////////  -------------  添加“试题”内容到对应“试题库”文件中  -----------////////////////
                //调用内部函数，分割填空题到文件中
                if (splitProblem(doc, "填空题", "选择题", fillInExam.试卷))
                {
                    //MessageBox.Show("填空题 添加成功！");
                }
                else
                {
                    MessageBox.Show("填空题 添加失败！");
                }
                //调用内部函数，分割选择题到文件中
                if (splitProblem(doc, "选择题", "判断题", choiceExam.试卷))
                {
                    //MessageBox.Show("选择题 添加成功！");
                }
                else
                {
                    MessageBox.Show("选择题 添加失败！");
                }
                //调用内部函数，分割判断题到文件中
                if (splitProblem(doc, "判断题", "计算题", trueOrFalseExam.试卷))
                {
                    //MessageBox.Show("判断题 添加成功！");
                }
                else
                {
                    MessageBox.Show("判断题 添加失败！");
                }
                //调用内部函数，分割计算题到文件中
                if (splitProblem(doc, "计算题", "", calculationExam.试卷))
                {
                    //MessageBox.Show("计算题 添加成功！");
                }
                else
                {
                    MessageBox.Show("计算题 添加失败！");
                }


                doc.Close();      //关闭 试题文件
                doc = app.Documents.Open(item.答案);   //打开对应的答案文件

                ///////////////  -------------  添加试题答案内容到对应“试题答案库”文件中  -----------////////////////
                //调用内部函数，分割填空题到文件中
                if (splitProblem(doc, "填空题", "选择题", fillInExam.答案))
                {
                    //MessageBox.Show("填空题 添加成功！");
                }
                else
                {
                    MessageBox.Show("填空题 添加失败！");
                }
                //调用内部函数，分割选择题到文件中
                if (splitProblem(doc, "选择题", "判断题", choiceExam.答案))
                {
                    //MessageBox.Show("选择题 添加成功！");
                }
                else
                {
                    MessageBox.Show("选择题 添加失败！");
                }
                //调用内部函数，分割判断题到文件中
                if (splitProblem(doc, "判断题", "计算题", trueOrFalseExam.答案))
                {
                    //MessageBox.Show("判断题 添加成功！");
                }
                else
                {
                    MessageBox.Show("判断题 添加失败！");
                }
                //调用内部函数，分割计算题到文件中
                if (splitProblem(doc, "计算题", "", calculationExam.答案))
                {
                    //MessageBox.Show("计算题 添加成功！");
                }
                else
                {
                    MessageBox.Show("计算题 添加失败！");
                }
                doc.Close();      //关闭 试题文件
            }

            
        }

       

       

        private bool splitProblem(Microsoft.Office.Interop.Word.Document doc, string aimProblem, string endProblem, string outFile)
        {
            var allRange = doc.Range();
            int positionStart = 0, positionEnd = 0;
            object findText = aimProblem;
            allRange.Find.ClearFormatting();   //清除查找条件（注意：查找条件是累加的，不清除会一直累加）
            if (allRange.Find.Execute(findText))  //找到之后，Range对象的范围将变为“填空题”三个字（找到的查找文本范围）。
            {
                //allRange.Select();
                //MessageBox.Show("位置： " + allRange.Start);//找到，显示位置为127
                positionStart = allRange.Start;    //保存找到的题目开始位置positionStart
            }
            else
            {
                MessageBox.Show("没有找到" + findText);
                //没有找到，设置range对象的开始位置为0
                positionStart = 0;
                return false;
            }

            if (endProblem != "")
            {
                //allRange = doc.Range(127,140);
                //allRange.Select();
                //allRange = doc.Range(127);
                //allRange.Select();
                allRange = doc.Range(positionStart);  //选择从找到位置开始的所有范围为range对象
                findText = endProblem;
                //查找试卷中第二类题名称：“选择题”
                //找到的位置的开始位置作为第一类题的结束位置
                allRange.Find.ClearFormatting(); //清除查找条件
                if (allRange.Find.Execute(findText))
                {
                    positionEnd = allRange.Start;
                }
                else
                {
                    MessageBox.Show("没有找到" + findText);
                    positionEnd = 0; //没有找到，设置range对象的结束位置为0
                    return false;
                }

                allRange = doc.Range(positionStart, positionEnd);
                allRange.Select();
                allRange.Copy();

            }
            else   // 结束位置为空，则选择后面的全部
            {
                allRange = doc.Range(positionStart);
                allRange.Select();
                allRange.Copy();
            }

            //打开填空题文件，将内容复制到文件中
            var app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = true;
            var docFillin = app.Documents.Open(outFile);
            //获得文档末尾的位置、
            var endPos = docFillin.Range().End;


            //////////////////////////////////////////
            //// 定位到打开文件的末尾位置（End位置），取末尾前一个位置为新区域的开始位置。
            //// 直接用末尾位置End会报错（out of range）
            //object start = docFillin.Range().End - 1;
            //docFillin.Range(start, start).Paste();    //以末尾位置前一个位置为新的区域，粘贴复制到剪贴板的内容。
            //docFillin.Save();                       // 保存文档
            //docFillin.Close();                      // 关闭文档
            //app.Quit();                             // 退出word应用程序
            //                                        //////////////////////////////////////////////////////////
            //// 上面代码能正确按照要求执行，正确！！


            try
            {
                ////////////////////////////////         新版本8     //////////////////
                //在文档的末尾插入一新行，为了将复制的内容粘贴到文档最后
                docFillin.Range().InsertParagraphAfter();
                docFillin.Range().InsertParagraphAfter();

                //选择插入的位置之后的区域，将复制的内容粘贴到文档末尾
                var pasteRange = docFillin.Range(endPos);
           
                pasteRange.Select();
                pasteRange.Paste();
                docFillin.Save();   //// 最新版本9：将Save（）函数放在try外面时，出现异常错误：{"RPC 服务器不可用。 (异常来自 HRESULT:0x800706BA)"}
                                    //// 放到这里后，错误没有发生了？？？？
                docFillin.Close();  ////最新版本9：将Close（）函数放在try外面时，出现异常错误：{"RPC 服务器不可用。 (异常来自 HRESULT:0x800706BA)"}
                                    //// 放到这里后，错误没有发生了？？？？
                app.Quit();         ////最新版本9：将app.Quit（）函数放在try外面时，出现异常错误：{"RPC 服务器不可用。 (异常来自 HRESULT:0x800706BA)"}
                                    //// 放到这里后，错误没有发生了？？？？

            }
            catch (System.Exception e)
            {
            }

            //docFillin.Save();   // 该语句放在这，有时会产生异常 // 注意： 当出现异常时，复制的内容已经粘贴到了 新文件当中，所有需要保存文件，不然就不能将内容保存下来了。
            //docFillin.Close();  // 该语句放在这，有时会产生异常
            //app.Quit();         // 该语句放在这，有时会产生异常
            ////////////////////////////////////////   新版本  ///////////////////

            return true;
        }

       

       

        //添加一个全局word文档对象
        Microsoft.Office.Interop.Word.Document AllDoc = null;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = true;
            // 将打开的文档对象赋给全局变量AllDoc
            AllDoc = app.Documents.Open(txtSourceFile.Text);
        }

        private void btnPasteAfter_Click(object sender, EventArgs e)
        {
            //选择需要复制的区域对象
            var copyRange = AllDoc.Range(30, 50);
            copyRange.Select();
            copyRange.Copy();  //复制选择好的区域
            //获得文档末尾的位置、
            var endPos = AllDoc.Range().End;

            //在文档的末尾插入一新行，为了将复制的内容粘贴到文档最后
            AllDoc.Range().InsertParagraphAfter();

            //选择插入的位置之后的区域，将复制的内容粘贴到文档末尾
            var pasteRange = AllDoc.Range(endPos);
            pasteRange.Paste();
        }

       
       
        
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    

}
