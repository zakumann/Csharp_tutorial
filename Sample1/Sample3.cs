using System.Windows.Forms;

class Sample3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Come here C# world!";

        Label lb = new Label();
        lb.Width = 150;
        lb.Text = "Let's Start C#!";
        lb.Parent = fm;

        Application.Run(fm);
    }
}