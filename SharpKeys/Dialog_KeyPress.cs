using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SharpKeys
{
    /// <summary>
    /// Summary description for Dialog_KeyPress.
    /// </summary>
    public class Dialog_KeyPress : System.Windows.Forms.Form, IMessageFilter
    {
        // passed in from the main form
        internal Hashtable m_hashKeys = null;

        // data handlers
        internal string m_strSelected = "";
        const string DISABLED_KEY = "Key is disabled\n(00_00)";
        private Panel mainPanel;
        private Button btnOK;
        private Button btnCancel;
        private Label lblKey;
        private Label label1;
        private Label label2;
        private Label lblPressed;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Dialog_KeyPress()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // required to activate the message hook for this dialog
            Application.AddMessageFilter(this);
        }

        private void Dialog_KeyPress_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // required to remove the message hook for this dialog
            Application.RemoveMessageFilter(this);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_KeyPress));
            this.mainPanel = new System.Windows.Forms.Panel();
            
            this.lblPressed = new System.Windows.Forms.Label();
            
            this.label2 = new System.Windows.Forms.Label();
         
            this.btnOK = new System.Windows.Forms.Button();
            
            this.btnCancel = new System.Windows.Forms.Button();
           
            this.lblKey = new System.Windows.Forms.Label();
         
            this.label1 = new System.Windows.Forms.Label();
         
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.lblPressed);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.btnOK);
            this.mainPanel.Controls.Add(this.btnCancel);
            this.mainPanel.Controls.Add(this.lblKey);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(22, 22);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(602, 325);
            this.mainPanel.TabIndex = 12;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.ForeColor = Color.White;
            this.mainPanel.BackColor = Color.Black;
            // 
            // lblPressed
            // 
            this.lblPressed.AutoSize = true;
            this.lblPressed.BackColor = System.Drawing.Color.Transparent;
            this.lblPressed.Location = new System.Drawing.Point(24, 70);
            this.lblPressed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPressed.Name = "lblPressed";
            this.lblPressed.Size = new System.Drawing.Size(0, 25);
            this.lblPressed.TabIndex = 17;
            this.lblPressed.ForeColor = Color.White;
            this.lblPressed.BackColor = Color.Black;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 6);
            this.label2.TabIndex = 16;
            this.label2.ForeColor = Color.White;
            this.label2.BackColor = Color.Black;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(292, 258);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 42);
            this.btnOK.TabIndex = 14;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.ForeColor = Color.White;
            this.btnOK.BackColor = Color.Black;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(440, 258);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.BackColor = Color.Black;
            // 
            // lblKey
            // 
            this.lblKey.BackColor = System.Drawing.Color.Transparent;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(26, 105);
            this.lblKey.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(548, 109);
            this.lblKey.TabIndex = 13;
            this.lblKey.Text = "(press a key)";
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKey.ForeColor = Color.White;
            this.lblKey.BackColor = Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Press a button on your keyboard.";
            this.label1.ForeColor = Color.White;
            this.label1.BackColor = Color.Black;
            // 
            // Dialog_KeyPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackColor = Color.Black;
            this.ForeColor = Color.Black;
            this.ClientSize = new System.Drawing.Size(647, 371);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog_KeyPress";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Type Key";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Dialog_KeyPress_Closing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dialog_KeyPress_Paint);
            this.Resize += new System.EventHandler(this.Dialog_KeyPress_Resize);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void ShowKeyCode(int nCode)
        {
            // set up UI label
            if (lblPressed.Text.Length == 0)
                lblPressed.Text = "You pressed: ";

            nCode = nCode >> 16;

            // zeroed bit 30 from documentation 
            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms646280%28v=vs.85%29.aspx?f=255&MSPPError=-2147217396   
            nCode = nCode & 0xBFFF;

            if (nCode == 0)
            {
                lblKey.Text = DISABLED_KEY;
                btnOK.Enabled = false;
                return;
            }

            // get the code from LPARAM
            // if it's more than 256 then it's an extended key and mapped to 0xE0nn
            string strCode = "";
            if (nCode > 0x0100)
            {
                strCode = string.Format("E0_{0,2:X}", (nCode - 0x0100));
            }
            else
            {
                strCode = string.Format("00_{0,2:X}", nCode);
            }
            strCode = strCode.Replace(" ", "0");

            // Look up the scan code in the hashtable
            string strShow = "";
            if (m_hashKeys != null)
            {
                strShow = string.Format("{0}\n({1})", m_hashKeys[strCode], strCode);
            }
            else
            {
                strShow = "Scan code: " + strCode;
            }
            lblKey.Text = strShow;

            // UI to collect only valid scancodes
            btnOK.Enabled = true;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x100) //0x100 == WM_KEYDOWN
                ShowKeyCode((int)m.LParam);
            // always return false because we're just watching messages; not
            // trapping them - this message comes from IMessageFilter!
            return false;
        }

        // button handlers - don't have to worry about null b/c they can't get to it
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            this.AcceptButton = btnOK;
            m_strSelected = lblKey.Text.Replace("\n", " ");
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.CancelButton = btnCancel;
            m_strSelected = "";
        }

        private void Dialog_KeyPress_Paint(object sender, PaintEventArgs e)
        {
            if (System.Windows.Forms.SystemInformation.HighContrast)
            {
                return;
            }
            
            Graphics graphics = e.Graphics;

            Rectangle rectangle = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle,
                           //Color.FromArgb(188, 188, 188), Color.FromArgb(225, 225, 225),
                           Color.FromArgb(0, 0, 0), Color.FromArgb(1, 1, 1),
                           LinearGradientMode.ForwardDiagonal);

            graphics.FillRectangle(linearGradientBrush, rectangle);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            if (System.Windows.Forms.SystemInformation.HighContrast)
            {
                return;
            }
            
            Graphics graphics = e.Graphics;

            Rectangle rectangle = new Rectangle(0, 0, mainPanel.Width, mainPanel.Height);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle,
                           //Color.FromArgb(209, 221, 228), Color.FromArgb(237, 239, 247), //Color.FromArgb(236, 241, 243), 
                           Color.FromArgb(53, 53, 53), Color.FromArgb(54, 54, 54), //Color.FromArgb(236, 241, 243), 
                           LinearGradientMode.Vertical);

            graphics.FillRectangle(linearGradientBrush, rectangle);
        }

        private void Dialog_KeyPress_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
