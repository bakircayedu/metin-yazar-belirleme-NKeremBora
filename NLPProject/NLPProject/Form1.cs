using NLPProject.structures.BHeap;
using NLPProject.structures.HashTable;
using NLPProject.structures.stack;

namespace NLPProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyStack _stack1 = new();
        MyStack _stack2 = new();
        string[] subs;
        NLPFunctions scaler = new();
        MyStack result_1;
        MyMyStack result_2;
        MyHashTable result_3 = new(1000);
        private void btnOpenTextFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            using OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "c:\\";
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtTextPath.Text = file.FileName;
                var filestrem = file.OpenFile();
                using StreamReader reader = new StreamReader(filestrem);
                fileContent = reader.ReadToEnd();
                subs = fileContent.Split("\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReadStack_Click(object sender, EventArgs e)
        {
            int i = 1, j = 1;
            foreach (var sub in subs)
                foreach(var word in sub.Split(" "))
                {
                    _stack1.Push(word, i, " ",j);
                    j++;
                }            
                i++;
            i = 1;
            foreach (var sub in subs)
                _stack2.Push(sub, i," ");
            print_1();
            result_1 = scaler.GetRidOfPunctuationSigns(_stack1);
            result_2 = scaler.FindUniqueWord(result_1);
        }


        private void print_1()
        {
            LBTextInfo.Items.Clear();
            int i = _stack2.Count, avg = 0;
            LBTextInfo.Items.Add("Toplam Cumle Sayisi: " + _stack2.Count);
            var items = _stack2.Clone();
            foreach (var item in items)
            {
                avg += item.WordCount;
                LBTextInfo.Items.Add(i.ToString() + ". Cumle kelime sayisi: " + item.WordCount);
                i--;
            }
            avg /= _stack2.Count;
            LBTextInfo.Items.Add("Metindeki cumlelerin ortalama Kelime sayisi: " + avg.ToString());
        }

        private void btnReadHashTable_Click(object sender, EventArgs e)
        {
            var list = result_2.Clone();
            foreach (var item in list)
                result_3.Add(item.PrepWord, item.Frequency);
        }
        

        private void btnReadHeap_Click(object sender, EventArgs e)
        {

            MaxHeap<WordInfo> heap = new(1000);
            MaxHeap<WordInfo> copy = new(1000);
            List<WordInfo> sorted = new();
            var items = result_2.Clone();
            foreach (var item in items)
                heap.Add(new WordInfo(item.PrepWord, item.Frequency));



            for (int i = 0; i < heap.Count; i++)
            {
            copy.Add(new WordInfo(heap.Array[i].PrepWord, heap.Array[i].Frequency));
            }

            int j = 0;

            while (!copy.IsEmpty())
            {
              var node = copy.DeleteMinMax();
              sorted.Add(node);
            }
            LBHeap.Items.Clear();
            int sayi;
            sayi = Convert.ToInt32(txtSayi.Text);
            foreach (var item in sorted)
            {
                if (item == null)
                    break;
                if (sayi == 0)
                    break;
                LBHeap.Items.Add(item.PrepWord + "  " + item.Frequency);
                sayi--;
            }


            


        }
    }
}