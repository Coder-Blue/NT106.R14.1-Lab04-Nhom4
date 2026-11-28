using NT106.R14._1_Lab04_Nhom4.Bai02;
using NT106.R14._1_Lab04_Nhom4.Bai03;
using NT106.R14._1_Lab04_Nhom4.Bai04;
using NT106.R14._1_Lab04_Nhom4.Bai07;

namespace NT106.R14._1_Lab04_Nhom4;

public partial class NavigationMenu : Form
{
    private Bai02Form? bai02Form;
    private Bai03Form? bai03Form;
    private Bai04Form? bai04Form;
    private Bai07Form? bai07Form;

    public NavigationMenu() => InitializeComponent();

    private void btnBai02_Click(object sender, EventArgs e)
    {
        if (bai02Form is null || bai02Form.IsDisposed)
        {
            bai02Form = new Bai02Form();
            bai02Form.FormClosed += (_, _) => bai02Form = null;
            bai02Form.Show(this);
            return;
        }

        bai02Form.Activate();
    }

    private void btnBai03_Click(object sender, EventArgs e)
    {
        if (bai03Form is null || bai03Form.IsDisposed)
        {
            bai03Form = new Bai03Form();
            bai03Form.FormClosed += (_, _) => bai03Form = null;
            bai03Form.Show(this);
            return;
        }

        bai03Form.Activate();
    }

    private void btnBai04_Click(object sender, EventArgs e)
    {
        if (bai04Form is null || bai04Form.IsDisposed)
        {
            bai04Form = new Bai04Form();
            bai04Form.FormClosed += (_, _) => bai04Form = null;
            bai04Form.Show(this);
            return;
        }

        bai04Form.Activate();
    }

    private void btnBai07_Click(object sender, EventArgs e)
    {
        if (bai07Form is null || bai07Form.IsDisposed)
        {
            bai07Form = new Bai07Form();
            bai07Form.FormClosed += (_, _) => bai07Form = null;
            bai07Form.Show(this);
            return;
        }

        bai07Form.Activate();
    }
}
