using NT106.R14._1_Lab04_Nhom4.Bai02;
using NT106.R14._1_Lab04_Nhom4.Bai03;

namespace NT106.R14._1_Lab04_Nhom4;

public partial class NavigationMenu : Form
{
    private Bai02Form? bai02Form;
    private Bai03Form? bai03Form;

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
}
