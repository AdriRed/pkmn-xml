namespace ConsoleApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.dgv_pkmnStats = new System.Windows.Forms.DataGridView();
            this.lbl_pkmnAbility = new System.Windows.Forms.Label();
            this.txb_pkmnHab = new System.Windows.Forms.TextBox();
            this.lbl_pkmnDesc = new System.Windows.Forms.Label();
            this.txb_pkmnDesc = new System.Windows.Forms.TextBox();
            this.lbl_pkmnType = new System.Windows.Forms.Label();
            this.txb_pkmnType = new System.Windows.Forms.TextBox();
            this.lbl_pkmnSpecie = new System.Windows.Forms.Label();
            this.txb_pkmnSpecie = new System.Windows.Forms.TextBox();
            this.lbl_pkmnNum = new System.Windows.Forms.Label();
            this.txb_pkmnNum = new System.Windows.Forms.TextBox();
            this.lbl_pkmnName = new System.Windows.Forms.Label();
            this.txb_pkmnName = new System.Windows.Forms.TextBox();
            this.pbx_pkmnSprite = new System.Windows.Forms.PictureBox();
            this.lbl_Find = new System.Windows.Forms.Label();
            this.txb_FindPkmn = new System.Windows.Forms.TextBox();
            this.btn_loadXML = new System.Windows.Forms.Button();
            this.lbl_pkmnStats = new System.Windows.Forms.Label();
            this.dgv_evos = new System.Windows.Forms.DataGridView();
            this.btn_selectEvo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pkmnStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pkmnSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pkmnStats
            // 
            this.dgv_pkmnStats.AllowUserToAddRows = false;
            this.dgv_pkmnStats.AllowUserToDeleteRows = false;
            this.dgv_pkmnStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_pkmnStats.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_pkmnStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pkmnStats.ColumnHeadersVisible = false;
            this.dgv_pkmnStats.Location = new System.Drawing.Point(370, 82);
            this.dgv_pkmnStats.Name = "dgv_pkmnStats";
            this.dgv_pkmnStats.ReadOnly = true;
            this.dgv_pkmnStats.RowHeadersVisible = false;
            this.dgv_pkmnStats.Size = new System.Drawing.Size(62, 139);
            this.dgv_pkmnStats.TabIndex = 42;
            // 
            // lbl_pkmnAbility
            // 
            this.lbl_pkmnAbility.AutoSize = true;
            this.lbl_pkmnAbility.Location = new System.Drawing.Point(24, 119);
            this.lbl_pkmnAbility.Name = "lbl_pkmnAbility";
            this.lbl_pkmnAbility.Size = new System.Drawing.Size(51, 13);
            this.lbl_pkmnAbility.TabIndex = 41;
            this.lbl_pkmnAbility.Text = "Habilidad";
            // 
            // txb_pkmnHab
            // 
            this.txb_pkmnHab.Location = new System.Drawing.Point(83, 116);
            this.txb_pkmnHab.Name = "txb_pkmnHab";
            this.txb_pkmnHab.ReadOnly = true;
            this.txb_pkmnHab.Size = new System.Drawing.Size(117, 20);
            this.txb_pkmnHab.TabIndex = 40;
            // 
            // lbl_pkmnDesc
            // 
            this.lbl_pkmnDesc.AutoSize = true;
            this.lbl_pkmnDesc.Location = new System.Drawing.Point(11, 145);
            this.lbl_pkmnDesc.Name = "lbl_pkmnDesc";
            this.lbl_pkmnDesc.Size = new System.Drawing.Size(66, 13);
            this.lbl_pkmnDesc.TabIndex = 39;
            this.lbl_pkmnDesc.Text = "Descripcion:";
            // 
            // txb_pkmnDesc
            // 
            this.txb_pkmnDesc.Location = new System.Drawing.Point(83, 142);
            this.txb_pkmnDesc.Multiline = true;
            this.txb_pkmnDesc.Name = "txb_pkmnDesc";
            this.txb_pkmnDesc.ReadOnly = true;
            this.txb_pkmnDesc.Size = new System.Drawing.Size(117, 96);
            this.txb_pkmnDesc.TabIndex = 38;
            // 
            // lbl_pkmnType
            // 
            this.lbl_pkmnType.AutoSize = true;
            this.lbl_pkmnType.Location = new System.Drawing.Point(215, 93);
            this.lbl_pkmnType.Name = "lbl_pkmnType";
            this.lbl_pkmnType.Size = new System.Drawing.Size(31, 13);
            this.lbl_pkmnType.TabIndex = 37;
            this.lbl_pkmnType.Text = "Tipo:";
            // 
            // txb_pkmnType
            // 
            this.txb_pkmnType.Location = new System.Drawing.Point(252, 90);
            this.txb_pkmnType.Name = "txb_pkmnType";
            this.txb_pkmnType.ReadOnly = true;
            this.txb_pkmnType.Size = new System.Drawing.Size(87, 20);
            this.txb_pkmnType.TabIndex = 36;
            // 
            // lbl_pkmnSpecie
            // 
            this.lbl_pkmnSpecie.AutoSize = true;
            this.lbl_pkmnSpecie.Location = new System.Drawing.Point(27, 93);
            this.lbl_pkmnSpecie.Name = "lbl_pkmnSpecie";
            this.lbl_pkmnSpecie.Size = new System.Drawing.Size(48, 13);
            this.lbl_pkmnSpecie.TabIndex = 35;
            this.lbl_pkmnSpecie.Text = "Especie:";
            // 
            // txb_pkmnSpecie
            // 
            this.txb_pkmnSpecie.Location = new System.Drawing.Point(83, 90);
            this.txb_pkmnSpecie.Name = "txb_pkmnSpecie";
            this.txb_pkmnSpecie.ReadOnly = true;
            this.txb_pkmnSpecie.Size = new System.Drawing.Size(117, 20);
            this.txb_pkmnSpecie.TabIndex = 34;
            // 
            // lbl_pkmnNum
            // 
            this.lbl_pkmnNum.AutoSize = true;
            this.lbl_pkmnNum.Location = new System.Drawing.Point(215, 67);
            this.lbl_pkmnNum.Name = "lbl_pkmnNum";
            this.lbl_pkmnNum.Size = new System.Drawing.Size(67, 13);
            this.lbl_pkmnNum.TabIndex = 33;
            this.lbl_pkmnNum.Text = "Pokémon Nº";
            // 
            // txb_pkmnNum
            // 
            this.txb_pkmnNum.Location = new System.Drawing.Point(288, 64);
            this.txb_pkmnNum.Name = "txb_pkmnNum";
            this.txb_pkmnNum.ReadOnly = true;
            this.txb_pkmnNum.Size = new System.Drawing.Size(51, 20);
            this.txb_pkmnNum.TabIndex = 32;
            // 
            // lbl_pkmnName
            // 
            this.lbl_pkmnName.AutoSize = true;
            this.lbl_pkmnName.Location = new System.Drawing.Point(27, 67);
            this.lbl_pkmnName.Name = "lbl_pkmnName";
            this.lbl_pkmnName.Size = new System.Drawing.Size(50, 13);
            this.lbl_pkmnName.TabIndex = 31;
            this.lbl_pkmnName.Text = "Nombre: ";
            // 
            // txb_pkmnName
            // 
            this.txb_pkmnName.Location = new System.Drawing.Point(83, 64);
            this.txb_pkmnName.Name = "txb_pkmnName";
            this.txb_pkmnName.ReadOnly = true;
            this.txb_pkmnName.Size = new System.Drawing.Size(117, 20);
            this.txb_pkmnName.TabIndex = 30;
            // 
            // pbx_pkmnSprite
            // 
            this.pbx_pkmnSprite.BackColor = System.Drawing.Color.White;
            this.pbx_pkmnSprite.Location = new System.Drawing.Point(226, 123);
            this.pbx_pkmnSprite.Name = "pbx_pkmnSprite";
            this.pbx_pkmnSprite.Size = new System.Drawing.Size(127, 129);
            this.pbx_pkmnSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_pkmnSprite.TabIndex = 29;
            this.pbx_pkmnSprite.TabStop = false;
            // 
            // lbl_Find
            // 
            this.lbl_Find.AutoSize = true;
            this.lbl_Find.Location = new System.Drawing.Point(199, 18);
            this.lbl_Find.Name = "lbl_Find";
            this.lbl_Find.Size = new System.Drawing.Size(154, 13);
            this.lbl_Find.TabIndex = 28;
            this.lbl_Find.Text = "Nombre o numero de Pokémon";
            // 
            // txb_FindPkmn
            // 
            this.txb_FindPkmn.Location = new System.Drawing.Point(194, 34);
            this.txb_FindPkmn.Name = "txb_FindPkmn";
            this.txb_FindPkmn.Size = new System.Drawing.Size(159, 20);
            this.txb_FindPkmn.TabIndex = 27;
            this.txb_FindPkmn.TextChanged += new System.EventHandler(this.txb_FindPkmn_TextChanged);
            // 
            // btn_loadXML
            // 
            this.btn_loadXML.Location = new System.Drawing.Point(30, 18);
            this.btn_loadXML.Name = "btn_loadXML";
            this.btn_loadXML.Size = new System.Drawing.Size(133, 32);
            this.btn_loadXML.TabIndex = 26;
            this.btn_loadXML.Text = "Load Xml";
            this.btn_loadXML.UseVisualStyleBackColor = true;
            this.btn_loadXML.Click += new System.EventHandler(this.btn_loadXML_Click);
            // 
            // lbl_pkmnStats
            // 
            this.lbl_pkmnStats.AutoSize = true;
            this.lbl_pkmnStats.Location = new System.Drawing.Point(367, 64);
            this.lbl_pkmnStats.Name = "lbl_pkmnStats";
            this.lbl_pkmnStats.Size = new System.Drawing.Size(65, 13);
            this.lbl_pkmnStats.TabIndex = 43;
            this.lbl_pkmnStats.Text = "Estadísticas";
            // 
            // dgv_evos
            // 
            this.dgv_evos.AllowUserToAddRows = false;
            this.dgv_evos.AllowUserToDeleteRows = false;
            this.dgv_evos.AllowUserToResizeColumns = false;
            this.dgv_evos.AllowUserToResizeRows = false;
            this.dgv_evos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_evos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_evos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_evos.ColumnHeadersVisible = false;
            this.dgv_evos.Location = new System.Drawing.Point(88, 259);
            this.dgv_evos.Name = "dgv_evos";
            this.dgv_evos.ReadOnly = true;
            this.dgv_evos.RowHeadersVisible = false;
            this.dgv_evos.Size = new System.Drawing.Size(91, 133);
            this.dgv_evos.TabIndex = 45;
            this.dgv_evos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_evos_CellContentClick);
            // 
            // btn_selectEvo
            // 
            this.btn_selectEvo.Location = new System.Drawing.Point(194, 315);
            this.btn_selectEvo.Name = "btn_selectEvo";
            this.btn_selectEvo.Size = new System.Drawing.Size(75, 23);
            this.btn_selectEvo.TabIndex = 46;
            this.btn_selectEvo.Text = "Info";
            this.btn_selectEvo.UseVisualStyleBackColor = true;
            this.btn_selectEvo.Click += new System.EventHandler(this.Btn_selectEvo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 525);
            this.Controls.Add(this.btn_selectEvo);
            this.Controls.Add(this.dgv_evos);
            this.Controls.Add(this.lbl_pkmnStats);
            this.Controls.Add(this.dgv_pkmnStats);
            this.Controls.Add(this.lbl_pkmnAbility);
            this.Controls.Add(this.txb_pkmnHab);
            this.Controls.Add(this.lbl_pkmnDesc);
            this.Controls.Add(this.txb_pkmnDesc);
            this.Controls.Add(this.lbl_pkmnType);
            this.Controls.Add(this.txb_pkmnType);
            this.Controls.Add(this.lbl_pkmnSpecie);
            this.Controls.Add(this.txb_pkmnSpecie);
            this.Controls.Add(this.lbl_pkmnNum);
            this.Controls.Add(this.txb_pkmnNum);
            this.Controls.Add(this.lbl_pkmnName);
            this.Controls.Add(this.txb_pkmnName);
            this.Controls.Add(this.pbx_pkmnSprite);
            this.Controls.Add(this.lbl_Find);
            this.Controls.Add(this.txb_FindPkmn);
            this.Controls.Add(this.btn_loadXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pkmnStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pkmnSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pkmnStats;
        private System.Windows.Forms.Label lbl_pkmnAbility;
        private System.Windows.Forms.TextBox txb_pkmnHab;
        private System.Windows.Forms.Label lbl_pkmnDesc;
        private System.Windows.Forms.TextBox txb_pkmnDesc;
        private System.Windows.Forms.Label lbl_pkmnType;
        private System.Windows.Forms.TextBox txb_pkmnType;
        private System.Windows.Forms.Label lbl_pkmnSpecie;
        private System.Windows.Forms.TextBox txb_pkmnSpecie;
        private System.Windows.Forms.Label lbl_pkmnNum;
        private System.Windows.Forms.TextBox txb_pkmnNum;
        private System.Windows.Forms.Label lbl_pkmnName;
        private System.Windows.Forms.TextBox txb_pkmnName;
        private System.Windows.Forms.PictureBox pbx_pkmnSprite;
        private System.Windows.Forms.Label lbl_Find;
        public System.Windows.Forms.TextBox txb_FindPkmn;
        private System.Windows.Forms.Button btn_loadXML;
        private System.Windows.Forms.Label lbl_pkmnStats;
        private System.Windows.Forms.DataGridView dgv_evos;
        private System.Windows.Forms.Button btn_selectEvo;
    }
}