using System.Windows.Forms;

class prac2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";

        Label lb = new Label();
        lb.Width = 150;

        lb.Text = "See you again!";
        lb.Parent = fm;

        Application.Run(fm);
    }
}