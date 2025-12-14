using SlotMachine_App.Logic;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SlotMachine_App.Forms
{
    public partial class MainForm : Form
    {
        private SlotGame slotGame;
        private Stopwatch stopwatch;
        private Timer updateTimer;

        public MainForm()
        {
            InitializeComponent();
            slotGame = new SlotGame();
            stopwatch = new Stopwatch();

            // Setează PictureBox-urile pentru stretch
            pictureBoxSlot1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSlot2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSlot3.SizeMode = PictureBoxSizeMode.StretchImage;

            // Arată panelul cu sloturi
            panelSloturi.Visible = true;
            pictureBoxSlot1.Visible = true;
            pictureBoxSlot2.Visible = true;
            pictureBoxSlot3.Visible = true;

            // Abonează-te la evenimentele SlotGame
            slotGame.OnCicluComplet += SlotGame_OnCicluComplet;
            slotGame.OnJocComplet += SlotGame_OnJocComplet;

            // Timer pentru update
            updateTimer = new Timer();
            updateTimer.Interval = 16; // ~60 FPS
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();

            stopwatch.Start();
        }

        private Image LoadImageForSlot(SlotItem item)
        {
            string imagePath = SlotItemHelper.GetImagePath(item);
            if (File.Exists(imagePath))
            {
                return Image.FromFile(imagePath);
            }
            return null;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            double dt = stopwatch.Elapsed.TotalSeconds;
            stopwatch.Restart();

            slotGame.Update(dt);
            UpdateSlotImages();
        }

        private void UpdateSlotImages()
        {
            SlotItem[] simboluri = slotGame.GetSimboluri();
            
            if (pictureBoxSlot1.Image != null)
                pictureBoxSlot1.Image.Dispose();
            if (pictureBoxSlot2.Image != null)
                pictureBoxSlot2.Image.Dispose();
            if (pictureBoxSlot3.Image != null)
                pictureBoxSlot3.Image.Dispose();

            pictureBoxSlot1.Image = LoadImageForSlot(simboluri[0]);
            pictureBoxSlot2.Image = LoadImageForSlot(simboluri[1]);
            pictureBoxSlot3.Image = LoadImageForSlot(simboluri[2]);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelRezultat.Text = "Apasă 'Trage!' pentru a începe!";
            labelRezultat.ForeColor = Color.Black;
        }

        private void btnTrage_Click(object sender, EventArgs e)
        {
            if (slotGame.IsRolling) return;

            // Resetează interfața
            labelRezultat.Text = "Se învârt sloturile...";
            labelRezultat.ForeColor = Color.Blue;

            // Dezactivează butonul în timpul jocului
            btnTrage.Enabled = false;
            numericUpDownCicluri.Enabled = false;

            // Începe jocul
            int nrCicluri = (int)numericUpDownCicluri.Value;
            slotGame.Trage(nrCicluri);
        }

        private void timerCiclu_Tick(object sender, EventArgs e)
        {
            // Nu mai este folosit - logica este în UpdateTimer_Tick
        }

        private void SlotGame_OnCicluComplet(SlotItem[] simboluri)
        {
            // Update status
            int cicluri = slotGame.GetCicluriRamase();
            labelRezultat.Text = $"Rotim... {cicluri} rămase";
        }

        private void SlotGame_OnJocComplet(bool aCastigat, SlotItem[] simboluri)
        {
            // Actualizează UI-ul final
            if (aCastigat)
            {
                labelRezultat.Text = "AI CÂȘTIGAT!";
                labelRezultat.ForeColor = Color.Green;
                MessageBox.Show("Ai câștigat!", "Felicitări!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                labelRezultat.Text = "Ai Pierdut! Încearcă din nou!";
                labelRezultat.ForeColor = Color.Red;
                MessageBox.Show("Ai pierdut.", "Mai încearcă!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Re-activează butonul
            btnTrage.Enabled = true;
            numericUpDownCicluri.Enabled = true;
        }
    }
}
