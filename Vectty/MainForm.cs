using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectty
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBlackPaper_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Paper = ZXClasses.ZXColor.Black;
            pnlPaper.BackColor = Color.Black;
        }

        private void btnBluePaper_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Paper = ZXClasses.ZXColor.Blue;
            pnlPaper.BackColor = Color.Blue;
        }

        private void btnRedPaper_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Paper = ZXClasses.ZXColor.Red;
            pnlPaper.BackColor = Color.Red;
        }

        private void btnPinkPaper_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Paper = ZXClasses.ZXColor.Magenta;
            pnlPaper.BackColor = Color.Magenta;
        }

        private void btnGreenPaper_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Paper = ZXClasses.ZXColor.Green;
            pnlPaper.BackColor = Color.FromArgb(0, 255, 0);
        }

        private void btnCyanPaper_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Paper = ZXClasses.ZXColor.Cyan;
            pnlPaper.BackColor = Color.Cyan;
        }

        private void btnYellowPaper_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Paper = ZXClasses.ZXColor.Yellow;
            pnlPaper.BackColor = Color.Yellow;
        }

        private void btnWhitePaper_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Paper = ZXClasses.ZXColor.White;
            pnlPaper.BackColor = Color.White;
        }

        private void btnBlackInk_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Ink = ZXClasses.ZXColor.Black;
            pnlInk.BackColor = Color.Black;
        }

        private void btnBlueInk_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Ink = ZXClasses.ZXColor.Blue;
            pnlInk.BackColor = Color.Blue;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Ink = ZXClasses.ZXColor.Red;
            pnlInk.BackColor = Color.Red;
        }

        private void btnPinkInk_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Ink = ZXClasses.ZXColor.Magenta;
            pnlInk.BackColor = Color.Magenta;
        }

        private void btnCyanInk_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Ink = ZXClasses.ZXColor.Cyan;
            pnlInk.BackColor = Color.Cyan;
        }

        private void btnGreenInk_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Ink = ZXClasses.ZXColor.Green;
            pnlInk.BackColor = Color.FromArgb(0, 255, 0);
        }

        private void btnYellowInk_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Ink = ZXClasses.ZXColor.Yellow;
            pnlInk.BackColor = Color.Yellow;
        }

        private void btnWhiteInk_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Ink = ZXClasses.ZXColor.White;
            pnlInk.BackColor = Color.White;
        }

        private void btnBright_Click(object sender, EventArgs e)
        {
            drawArea.ActiveAttribute.Bright = !drawArea.ActiveAttribute.Bright;
            pnlBright.BackgroundImage = drawArea.ActiveAttribute.Bright ? Vectty.Properties.Resources.BrightOn : Vectty.Properties.Resources.BrightOff;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            drawArea.Tool = SpeccyDrawControlTool.Line;
            pnlTool.BackgroundImage = btnLine.Image;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            drawArea.Tool = SpeccyDrawControlTool.Circle;
            pnlTool.BackgroundImage = btnCircle.Image;
        }

        private void btnArc_Click(object sender, EventArgs e)
        {
            drawArea.Tool = SpeccyDrawControlTool.Arc;
            pnlTool.BackgroundImage = btnArc.Image;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            drawArea.Tool = SpeccyDrawControlTool.Fill;
            pnlTool.BackgroundImage = btnFill.Image;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            drawArea.Tool = SpeccyDrawControlTool.BlockEraser;
            pnlTool.BackgroundImage = btnErase.Image;
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            drawArea.Tool = SpeccyDrawControlTool.Brush;
            pnlTool.BackgroundImage = btnBrush.Image;
        }

        private void btnBitmap_Click(object sender, EventArgs e)
        {
            drawArea.Mode = SpeccyDrawControlMode.Bitmap;
            pnlMode.BackgroundImage = btnBitmap.Image;
        }

        private void btnInk_Click(object sender, EventArgs e)
        {
            drawArea.Mode = SpeccyDrawControlMode.Ink;
            pnlMode.BackgroundImage = btnInk.Image;
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            drawArea.Mode = SpeccyDrawControlMode.Paper;
            pnlMode.BackgroundImage = btnPaper.Image;
        }

        private void btnInkPaper_Click(object sender, EventArgs e)
        {
            drawArea.Mode = SpeccyDrawControlMode.InkPaper;
            pnlMode.BackgroundImage = btnInkPaper.Image;
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            drawArea.Grid = !drawArea.Grid;
            drawArea.Refresh();
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            drawArea.Tool = SpeccyDrawControlTool.Rectangle;
            pnlTool.BackgroundImage = btnRect.Image;
        }

        private void drawArea_HistoryChanged(object sender, EventArgs e)
        {
            btnUndo.Enabled = drawArea.CanUndo;
            btnRedo.Enabled = drawArea.CanRedo;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            drawArea.Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            drawArea.Redo();
        }

        private void btnSetInk_Click(object sender, EventArgs e)
        {
            drawArea.FillInk();
        }

        private void btnSetPaper_Click(object sender, EventArgs e)
        {
            drawArea.FillPaper();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog { Filter = "Vectty drawing|*.vct" })
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                if (drawArea.SaveFile(dlg.FileName))
                    MessageBox.Show("File saved");
                else
                    MessageBox.Show("Error saving file");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear the drawing?", "New drawing", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            drawArea.Cleanup();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Vectty drawing|*.vct" })
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                drawArea.LoadFile(dlg.FileName);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var dlg = new ExportTypeSelector())
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                if (drawArea.ExportFile(dlg.FileName, dlg.Mode))
                    MessageBox.Show("File exported");
                else
                    MessageBox.Show("Error exporting file");
            }
        }

    }
}
