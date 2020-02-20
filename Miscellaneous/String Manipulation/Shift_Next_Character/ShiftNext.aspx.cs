using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShiftNext : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnShowResult_Click(object sender, EventArgs e)
    {
        string inputStr = txtInputString.Text.Trim();

        string result = string.Empty;

        char[] charArray = inputStr.ToCharArray();

        foreach (char singleChar in charArray)
        {
            bool isCharUpper = char.IsUpper(singleChar);
            char tempChar;

            if (singleChar == 'Z' || singleChar == 'z')
            {
                tempChar = 'a';
                if (isCharUpper) tempChar = 'A';
            }
            else
            {
                tempChar = (char)(singleChar + 1);
            }

            result += tempChar;
        }

        lblResult.Text = result;
    }
}