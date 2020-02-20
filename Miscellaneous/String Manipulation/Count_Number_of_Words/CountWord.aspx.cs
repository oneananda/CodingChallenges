using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CountWord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnShowResult_Click(object sender, EventArgs e)
    {
        string givenString = txtInputString.Text.Trim();

        StringBuilder StrResult = new StringBuilder();

        List<string> Str1 = givenString.Split(' ').ToList();

        Hashtable HtUniqeString = new Hashtable();

        foreach (string SingleStr1 in Str1)
        {
            if (SingleStr1.Trim() != string.Empty)// Excluding any extra spaces
            {
                string TempString = SingleStr1.Replace(',', ' ');// Remoce any commas
                if (!HtUniqeString.ContainsKey(TempString.Trim()))
                {
                    HtUniqeString.Add(SingleStr1, "");
                }
            }
        }
        foreach (DictionaryEntry DictEntry in HtUniqeString)
        {
            int Count = 0;
            foreach (string SingleStr1 in Str1)
            {
                // Compare the strings irrespective of case
                if (SingleStr1.Equals(DictEntry.Key.ToString(), StringComparison.InvariantCultureIgnoreCase))
                    Count++;
            }
            string Time = "Time";
            if (Count > 1) Time = "Times";
            StrResult.AppendLine("'" + DictEntry.Key.ToString() + "' has occured " + Count.ToString() + " " + Time + " ,");
            //_CountWordModel.OutputMessages.Add("'" + DictEntry.Key.ToString() + "' has occured " + Count.ToString() + " " + Time);
            //Console.WriteLine(DictEntry.Key.ToString() + " has occured " + Count.ToString() + " times");
        }

        lblResult.Text = StrResult.ToString();
    }
}