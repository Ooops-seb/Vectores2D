﻿using System.Drawing;

namespace Vectores
{
    partial class Frm_Vector
    {
        Bitmap mig;
        Graphics imEditor;
        Pen penGrosor;
        SolidBrush brushRelleno;
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label62 = new System.Windows.Forms.Label();
            this.txtGeneralX = new System.Windows.Forms.TextBox();
            this.txtGeneralY = new System.Windows.Forms.TextBox();
            this.pictureBox_FreeDraw = new System.Windows.Forms.PictureBox();
            this.pctBox_Graph = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_ReDraw = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PieMenu = new System.Windows.Forms.Panel();
            this.label61 = new System.Windows.Forms.Label();
            this.Panel_SubMenuDibujoLibre = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.Btn_MenuDibujoLibre = new System.Windows.Forms.Button();
            this.Panel_SubMenuRecta = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtPuntoY = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.txtPuntoX = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPuntoBy = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtPuntoBx = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtPuntoAy = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtPuntoAx = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.boxEcuacion = new System.Windows.Forms.GroupBox();
            this.txtEcuacionB = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.txtEcuacionY = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.txtEcuacionX = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.btn_CalcularEcuacionRecta = new System.Windows.Forms.Button();
            this.Btn_SubMenuRecta = new System.Windows.Forms.Button();
            this.Btn_DibujarEcuaciones = new System.Windows.Forms.Button();
            this.Panel_DibujarFiguras = new System.Windows.Forms.Panel();
            this.Panel_SubMenuDibujarCuadrado = new System.Windows.Forms.Panel();
            this.Panel_Cuadrado = new System.Windows.Forms.Panel();
            this.Btn_DibujarFigurasCuadrado = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtCuadradoPuntoBy = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.txtCuadradoPuntoBx = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txtCuadradoPuntoAy = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtCuadradoPuntoAx = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.Panel_CuadradoDibujar = new System.Windows.Forms.Panel();
            this.lblAlturaCuadrado = new System.Windows.Forms.Label();
            this.lblBaseCuadrado = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.lblAreaCuadrado = new System.Windows.Forms.Label();
            this.lblPerimetroCuadrado = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.Btn_SubMenuCuadrado = new System.Windows.Forms.Button();
            this.Panel_SubMenuDibujarTriangulo = new System.Windows.Forms.Panel();
            this.Panel_Triangulo = new System.Windows.Forms.Panel();
            this.Btn_DibujarFigurasTriangulo = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txtTrianguloBy = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.txtTrianguloBx = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.txtTrianguloAy = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.txtTrianguloAx = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.Panel_TrianguloDibujar = new System.Windows.Forms.Panel();
            this.lblAlturaTriangulo = new System.Windows.Forms.Label();
            this.lblBaseTriangulo = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.lblAreaTriangulo = new System.Windows.Forms.Label();
            this.lblPerimetroTriangulo = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.Btn_SubMenuTriangulo = new System.Windows.Forms.Button();
            this.Panel_SubMenuDibujarCirculo = new System.Windows.Forms.Panel();
            this.Panel_DatosCirculo = new System.Windows.Forms.Panel();
            this.txtRadioCirculo = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.Btn_DibujarCirculo = new System.Windows.Forms.Button();
            this.label82 = new System.Windows.Forms.Label();
            this.Panel_ResultadoCirculo = new System.Windows.Forms.Panel();
            this.lblAreaCirculo = new System.Windows.Forms.Label();
            this.lblPerimetroCirculo = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.Btn_SubMenuCirculo = new System.Windows.Forms.Button();
            this.Btn_DibujarFiguras = new System.Windows.Forms.Button();
            this.Panel_MenuDibujarOrigen = new System.Windows.Forms.Panel();
            this.PanelSubMenuOperations = new System.Windows.Forms.Panel();
            this.PanelSubMenuOperationsProducto = new System.Windows.Forms.Panel();
            this.PanelProductoVector = new System.Windows.Forms.Panel();
            this.lblResultadoProducto = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblProductoX2 = new System.Windows.Forms.Label();
            this.lblProductoX1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lblProductoY2 = new System.Windows.Forms.Label();
            this.lblProductoY1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.PanelProducto = new System.Windows.Forms.Panel();
            this.BtnCalcularProducto = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtVectorProductoY2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtVectorProductoX2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtVectorProductoY1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtVectorProductoX1 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Btn_SubMenuOperationsProducto = new System.Windows.Forms.Button();
            this.PanelSubMenuOperationsResta = new System.Windows.Forms.Panel();
            this.PanelRestaVector = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblRestaY = new System.Windows.Forms.Label();
            this.lblRestaX = new System.Windows.Forms.Label();
            this.Btn_CalcularResta = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.PanelResta = new System.Windows.Forms.Panel();
            this.BtnCalcularResta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVectorRestaY2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVectorRestaX2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVectorRestaY1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtVectorRestaX1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Btn_SubMenuOperationsResta = new System.Windows.Forms.Button();
            this.PanelSubMenuOperationsSuma = new System.Windows.Forms.Panel();
            this.PanelSumaVector = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblSumaY = new System.Windows.Forms.Label();
            this.lblSumaX = new System.Windows.Forms.Label();
            this.Btn_CalcularSuma = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.PanelSuma = new System.Windows.Forms.Panel();
            this.BtnCalcularSuma = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtSumaVectorY2 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtSumaVectorX2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtSumaVectorY1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSumaVectorX1 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.Btn_SubMenuOperationsSuma = new System.Windows.Forms.Button();
            this.PanelSubMenuOperationsSentido = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVectorActualY_PnlCambiarSentido = new System.Windows.Forms.Label();
            this.BtnCambiarSentido = new System.Windows.Forms.Button();
            this.lblVectorActualX_PnlCambiarSentido = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_SubMenuOperationsSentido = new System.Windows.Forms.Button();
            this.PanelSubMenuOperationsEscalar = new System.Windows.Forms.Panel();
            this.lblVectorActual_PnlEscalar = new System.Windows.Forms.Label();
            this.BtnAplicarEscalar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEscalar = new System.Windows.Forms.TextBox();
            this.Btn_SubMenuOperationsEscalar = new System.Windows.Forms.Button();
            this.BtnMenuOperations = new System.Windows.Forms.Button();
            this.Panel_SubMenuDibujar = new System.Windows.Forms.Panel();
            this.linkLabel_Animar = new System.Windows.Forms.LinkLabel();
            this.Btn_DrawVector = new System.Windows.Forms.Button();
            this.txtAxisY = new System.Windows.Forms.TextBox();
            this.txtAxisX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_MenuDibujarOrigen = new System.Windows.Forms.Button();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.PanelDetallesGrafico = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCuadrante = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMagnitud = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_DrawMap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FreeDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Graph)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PieMenu.SuspendLayout();
            this.Panel_SubMenuDibujoLibre.SuspendLayout();
            this.Panel_SubMenuRecta.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.boxEcuacion.SuspendLayout();
            this.Panel_DibujarFiguras.SuspendLayout();
            this.Panel_SubMenuDibujarCuadrado.SuspendLayout();
            this.Panel_Cuadrado.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.Panel_CuadradoDibujar.SuspendLayout();
            this.Panel_SubMenuDibujarTriangulo.SuspendLayout();
            this.Panel_Triangulo.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.Panel_TrianguloDibujar.SuspendLayout();
            this.Panel_SubMenuDibujarCirculo.SuspendLayout();
            this.Panel_DatosCirculo.SuspendLayout();
            this.Panel_ResultadoCirculo.SuspendLayout();
            this.Panel_MenuDibujarOrigen.SuspendLayout();
            this.PanelSubMenuOperations.SuspendLayout();
            this.PanelSubMenuOperationsProducto.SuspendLayout();
            this.PanelProductoVector.SuspendLayout();
            this.PanelProducto.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.PanelSubMenuOperationsResta.SuspendLayout();
            this.PanelRestaVector.SuspendLayout();
            this.PanelResta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PanelSubMenuOperationsSuma.SuspendLayout();
            this.PanelSumaVector.SuspendLayout();
            this.PanelSuma.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.PanelSubMenuOperationsSentido.SuspendLayout();
            this.PanelSubMenuOperationsEscalar.SuspendLayout();
            this.Panel_SubMenuDibujar.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.PanelDetallesGrafico.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label62);
            this.groupBox1.Controls.Add(this.txtGeneralX);
            this.groupBox1.Controls.Add(this.txtGeneralY);
            this.groupBox1.Controls.Add(this.pictureBox_FreeDraw);
            this.groupBox1.Controls.Add(this.pctBox_Graph);
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(306, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 605);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plano";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label62.ForeColor = System.Drawing.Color.Black;
            this.label62.Location = new System.Drawing.Point(394, 585);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(83, 17);
            this.label62.TabIndex = 19;
            this.label62.Text = "Coordenadas:";
            // 
            // txtGeneralX
            // 
            this.txtGeneralX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtGeneralX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGeneralX.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtGeneralX.Location = new System.Drawing.Point(483, 584);
            this.txtGeneralX.Name = "txtGeneralX";
            this.txtGeneralX.Size = new System.Drawing.Size(35, 19);
            this.txtGeneralX.TabIndex = 18;
            this.txtGeneralX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGeneralY
            // 
            this.txtGeneralY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtGeneralY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGeneralY.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtGeneralY.Location = new System.Drawing.Point(524, 584);
            this.txtGeneralY.Name = "txtGeneralY";
            this.txtGeneralY.Size = new System.Drawing.Size(35, 19);
            this.txtGeneralY.TabIndex = 17;
            this.txtGeneralY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox_FreeDraw
            // 
            this.pictureBox_FreeDraw.BackColor = System.Drawing.Color.White;
            this.pictureBox_FreeDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_FreeDraw.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_FreeDraw.Location = new System.Drawing.Point(9, 28);
            this.pictureBox_FreeDraw.Name = "pictureBox_FreeDraw";
            this.pictureBox_FreeDraw.Size = new System.Drawing.Size(550, 550);
            this.pictureBox_FreeDraw.TabIndex = 1;
            this.pictureBox_FreeDraw.TabStop = false;
            this.pictureBox_FreeDraw.Visible = false;
            this.pictureBox_FreeDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_FreeDraw_MouseMove);
            // 
            // pctBox_Graph
            // 
            this.pctBox_Graph.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pctBox_Graph.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctBox_Graph.Location = new System.Drawing.Point(9, 28);
            this.pctBox_Graph.Name = "pctBox_Graph";
            this.pctBox_Graph.Size = new System.Drawing.Size(550, 550);
            this.pctBox_Graph.TabIndex = 0;
            this.pctBox_Graph.TabStop = false;
            this.pctBox_Graph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctBox_Graph_MouseDown);
            this.pctBox_Graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctBox_Graph_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corinthia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 62);
            this.label3.TabIndex = 5;
            this.label3.Text = "Computación Gráfica";
            // 
            // Btn_ReDraw
            // 
            this.Btn_ReDraw.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_ReDraw.Location = new System.Drawing.Point(336, 21);
            this.Btn_ReDraw.Name = "Btn_ReDraw";
            this.Btn_ReDraw.Size = new System.Drawing.Size(66, 29);
            this.Btn_ReDraw.TabIndex = 3;
            this.Btn_ReDraw.Text = "Limpiar";
            this.Btn_ReDraw.UseVisualStyleBackColor = true;
            this.Btn_ReDraw.Visible = false;
            this.Btn_ReDraw.Click += new System.EventHandler(this.Btn_ReDraw_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.PanelPrincipal.Controls.Add(this.PanelMenu);
            this.PanelPrincipal.Controls.Add(this.PanelTitle);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(300, 661);
            this.PanelPrincipal.TabIndex = 6;
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.Controls.Add(this.PieMenu);
            this.PanelMenu.Controls.Add(this.Panel_SubMenuDibujoLibre);
            this.PanelMenu.Controls.Add(this.Btn_MenuDibujoLibre);
            this.PanelMenu.Controls.Add(this.Panel_SubMenuRecta);
            this.PanelMenu.Controls.Add(this.Btn_SubMenuRecta);
            this.PanelMenu.Controls.Add(this.Btn_DibujarEcuaciones);
            this.PanelMenu.Controls.Add(this.Panel_DibujarFiguras);
            this.PanelMenu.Controls.Add(this.Btn_DibujarFiguras);
            this.PanelMenu.Controls.Add(this.Panel_MenuDibujarOrigen);
            this.PanelMenu.Controls.Add(this.Btn_MenuDibujarOrigen);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 100);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(300, 561);
            this.PanelMenu.TabIndex = 8;
            // 
            // PieMenu
            // 
            this.PieMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PieMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(37)))));
            this.PieMenu.Controls.Add(this.label61);
            this.PieMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PieMenu.Location = new System.Drawing.Point(0, 2606);
            this.PieMenu.Name = "PieMenu";
            this.PieMenu.Size = new System.Drawing.Size(283, 35);
            this.PieMenu.TabIndex = 19;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Corinthia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label61.Location = new System.Drawing.Point(96, 5);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(91, 24);
            this.label61.TabIndex = 18;
            this.label61.Text = "ESPE - 2022";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_SubMenuDibujoLibre
            // 
            this.Panel_SubMenuDibujoLibre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_SubMenuDibujoLibre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.Panel_SubMenuDibujoLibre.Controls.Add(this.label52);
            this.Panel_SubMenuDibujoLibre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SubMenuDibujoLibre.Location = new System.Drawing.Point(0, 2543);
            this.Panel_SubMenuDibujoLibre.Name = "Panel_SubMenuDibujoLibre";
            this.Panel_SubMenuDibujoLibre.Size = new System.Drawing.Size(283, 63);
            this.Panel_SubMenuDibujoLibre.TabIndex = 12;
            this.Panel_SubMenuDibujoLibre.Visible = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Corinthia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label52.Location = new System.Drawing.Point(50, 13);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(184, 38);
            this.label52.TabIndex = 18;
            this.label52.Text = "¡Dibuje con el corazón!";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_MenuDibujoLibre
            // 
            this.Btn_MenuDibujoLibre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(111)))), ((int)(((byte)(185)))));
            this.Btn_MenuDibujoLibre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_MenuDibujoLibre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Btn_MenuDibujoLibre.FlatAppearance.BorderSize = 0;
            this.Btn_MenuDibujoLibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MenuDibujoLibre.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_MenuDibujoLibre.ForeColor = System.Drawing.Color.White;
            this.Btn_MenuDibujoLibre.Location = new System.Drawing.Point(0, 2503);
            this.Btn_MenuDibujoLibre.Name = "Btn_MenuDibujoLibre";
            this.Btn_MenuDibujoLibre.Size = new System.Drawing.Size(283, 40);
            this.Btn_MenuDibujoLibre.TabIndex = 11;
            this.Btn_MenuDibujoLibre.Text = "Dibujo Libre";
            this.Btn_MenuDibujoLibre.UseVisualStyleBackColor = false;
            this.Btn_MenuDibujoLibre.Click += new System.EventHandler(this.Btn_MenuDibujoLibre_Click);
            // 
            // Panel_SubMenuRecta
            // 
            this.Panel_SubMenuRecta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.Panel_SubMenuRecta.Controls.Add(this.groupBox11);
            this.Panel_SubMenuRecta.Controls.Add(this.groupBox10);
            this.Panel_SubMenuRecta.Controls.Add(this.btn_CalcularEcuacionRecta);
            this.Panel_SubMenuRecta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SubMenuRecta.Location = new System.Drawing.Point(0, 2123);
            this.Panel_SubMenuRecta.Name = "Panel_SubMenuRecta";
            this.Panel_SubMenuRecta.Size = new System.Drawing.Size(283, 380);
            this.Panel_SubMenuRecta.TabIndex = 12;
            this.Panel_SubMenuRecta.Visible = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtPendiente);
            this.groupBox11.Controls.Add(this.txtAngle);
            this.groupBox11.Controls.Add(this.label51);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Controls.Add(this.label48);
            this.groupBox11.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox11.Location = new System.Drawing.Point(3, 219);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(272, 155);
            this.groupBox11.TabIndex = 37;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Punto - Recta";
            // 
            // txtPendiente
            // 
            this.txtPendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPendiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPendiente.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtPendiente.Location = new System.Drawing.Point(103, 25);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Size = new System.Drawing.Size(35, 19);
            this.txtPendiente.TabIndex = 41;
            this.txtPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAngle
            // 
            this.txtAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtAngle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAngle.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtAngle.Location = new System.Drawing.Point(163, 124);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(35, 19);
            this.txtAngle.TabIndex = 14;
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label51.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label51.Location = new System.Drawing.Point(24, 127);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(121, 17);
            this.label51.TabIndex = 40;
            this.label51.Text = "Ángulo respecto a X: ";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtPuntoY);
            this.groupBox12.Controls.Add(this.label49);
            this.groupBox12.Controls.Add(this.txtPuntoX);
            this.groupBox12.Controls.Add(this.label50);
            this.groupBox12.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox12.Location = new System.Drawing.Point(24, 52);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(205, 62);
            this.groupBox12.TabIndex = 39;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Punto A";
            // 
            // txtPuntoY
            // 
            this.txtPuntoY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoY.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtPuntoY.Location = new System.Drawing.Point(149, 34);
            this.txtPuntoY.Name = "txtPuntoY";
            this.txtPuntoY.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoY.TabIndex = 13;
            this.txtPuntoY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label49.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label49.Location = new System.Drawing.Point(22, 31);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(18, 17);
            this.label49.TabIndex = 10;
            this.label49.Text = "X:";
            // 
            // txtPuntoX
            // 
            this.txtPuntoX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoX.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtPuntoX.Location = new System.Drawing.Point(57, 31);
            this.txtPuntoX.Name = "txtPuntoX";
            this.txtPuntoX.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoX.TabIndex = 12;
            this.txtPuntoX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label50.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label50.Location = new System.Drawing.Point(114, 34);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(17, 17);
            this.label50.TabIndex = 11;
            this.label50.Text = "Y:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label48.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label48.Location = new System.Drawing.Point(25, 25);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(67, 17);
            this.label48.TabIndex = 33;
            this.label48.Text = "Pendiente: ";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox8);
            this.groupBox10.Controls.Add(this.groupBox9);
            this.groupBox10.Controls.Add(this.boxEcuacion);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.White;
            this.groupBox10.Location = new System.Drawing.Point(3, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(272, 181);
            this.groupBox10.TabIndex = 36;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Punto - Recta";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtPuntoBy);
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Controls.Add(this.label42);
            this.groupBox8.Controls.Add(this.txtPuntoBx);
            this.groupBox8.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox8.Location = new System.Drawing.Point(146, 88);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(123, 88);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Punto B";
            // 
            // txtPuntoBy
            // 
            this.txtPuntoBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoBy.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtPuntoBy.Location = new System.Drawing.Point(48, 59);
            this.txtPuntoBy.Name = "txtPuntoBy";
            this.txtPuntoBy.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoBy.TabIndex = 17;
            this.txtPuntoBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label39.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label39.Location = new System.Drawing.Point(13, 31);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(18, 17);
            this.label39.TabIndex = 14;
            this.label39.Text = "X:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label42.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label42.Location = new System.Drawing.Point(13, 59);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(17, 17);
            this.label42.TabIndex = 15;
            this.label42.Text = "Y:";
            // 
            // txtPuntoBx
            // 
            this.txtPuntoBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoBx.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtPuntoBx.Location = new System.Drawing.Point(48, 31);
            this.txtPuntoBx.Name = "txtPuntoBx";
            this.txtPuntoBx.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoBx.TabIndex = 16;
            this.txtPuntoBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtPuntoAy);
            this.groupBox9.Controls.Add(this.label46);
            this.groupBox9.Controls.Add(this.txtPuntoAx);
            this.groupBox9.Controls.Add(this.label47);
            this.groupBox9.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox9.Location = new System.Drawing.Point(3, 88);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(123, 88);
            this.groupBox9.TabIndex = 38;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Punto A";
            // 
            // txtPuntoAy
            // 
            this.txtPuntoAy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoAy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoAy.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtPuntoAy.Location = new System.Drawing.Point(57, 59);
            this.txtPuntoAy.Name = "txtPuntoAy";
            this.txtPuntoAy.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoAy.TabIndex = 13;
            this.txtPuntoAy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label46.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label46.Location = new System.Drawing.Point(22, 31);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(18, 17);
            this.label46.TabIndex = 10;
            this.label46.Text = "X:";
            // 
            // txtPuntoAx
            // 
            this.txtPuntoAx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoAx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoAx.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtPuntoAx.Location = new System.Drawing.Point(57, 31);
            this.txtPuntoAx.Name = "txtPuntoAx";
            this.txtPuntoAx.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoAx.TabIndex = 12;
            this.txtPuntoAx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label47.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label47.Location = new System.Drawing.Point(22, 59);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(17, 17);
            this.label47.TabIndex = 11;
            this.label47.Text = "Y:";
            // 
            // boxEcuacion
            // 
            this.boxEcuacion.Controls.Add(this.txtEcuacionB);
            this.boxEcuacion.Controls.Add(this.label76);
            this.boxEcuacion.Controls.Add(this.txtEcuacionY);
            this.boxEcuacion.Controls.Add(this.label74);
            this.boxEcuacion.Controls.Add(this.txtEcuacionX);
            this.boxEcuacion.Controls.Add(this.label75);
            this.boxEcuacion.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.boxEcuacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.boxEcuacion.Location = new System.Drawing.Point(15, 21);
            this.boxEcuacion.Name = "boxEcuacion";
            this.boxEcuacion.Size = new System.Drawing.Size(243, 61);
            this.boxEcuacion.TabIndex = 35;
            this.boxEcuacion.TabStop = false;
            this.boxEcuacion.Text = "Ecuación";
            // 
            // txtEcuacionB
            // 
            this.txtEcuacionB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtEcuacionB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEcuacionB.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtEcuacionB.Location = new System.Drawing.Point(146, 30);
            this.txtEcuacionB.Name = "txtEcuacionB";
            this.txtEcuacionB.Size = new System.Drawing.Size(30, 19);
            this.txtEcuacionB.TabIndex = 15;
            this.txtEcuacionB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label76.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label76.Location = new System.Drawing.Point(187, 29);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(26, 17);
            this.label76.TabIndex = 14;
            this.label76.Text = "=  0";
            // 
            // txtEcuacionY
            // 
            this.txtEcuacionY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtEcuacionY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEcuacionY.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtEcuacionY.Location = new System.Drawing.Point(81, 30);
            this.txtEcuacionY.Name = "txtEcuacionY";
            this.txtEcuacionY.Size = new System.Drawing.Size(30, 19);
            this.txtEcuacionY.TabIndex = 13;
            this.txtEcuacionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label74.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label74.Location = new System.Drawing.Point(50, 29);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(26, 17);
            this.label74.TabIndex = 10;
            this.label74.Text = "x  +";
            // 
            // txtEcuacionX
            // 
            this.txtEcuacionX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtEcuacionX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEcuacionX.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtEcuacionX.Location = new System.Drawing.Point(14, 30);
            this.txtEcuacionX.Name = "txtEcuacionX";
            this.txtEcuacionX.Size = new System.Drawing.Size(30, 19);
            this.txtEcuacionX.TabIndex = 12;
            this.txtEcuacionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label75.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label75.Location = new System.Drawing.Point(117, 29);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(26, 17);
            this.label75.TabIndex = 11;
            this.label75.Text = "y  +";
            // 
            // btn_CalcularEcuacionRecta
            // 
            this.btn_CalcularEcuacionRecta.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_CalcularEcuacionRecta.Location = new System.Drawing.Point(105, 193);
            this.btn_CalcularEcuacionRecta.Name = "btn_CalcularEcuacionRecta";
            this.btn_CalcularEcuacionRecta.Size = new System.Drawing.Size(68, 26);
            this.btn_CalcularEcuacionRecta.TabIndex = 25;
            this.btn_CalcularEcuacionRecta.Text = "Calcular";
            this.btn_CalcularEcuacionRecta.UseVisualStyleBackColor = true;
            this.btn_CalcularEcuacionRecta.Click += new System.EventHandler(this.btn_CalcularEcuacionRecta_Click);
            // 
            // Btn_SubMenuRecta
            // 
            this.Btn_SubMenuRecta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.Btn_SubMenuRecta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuRecta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuRecta.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuRecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuRecta.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_SubMenuRecta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_SubMenuRecta.Location = new System.Drawing.Point(0, 2093);
            this.Btn_SubMenuRecta.Name = "Btn_SubMenuRecta";
            this.Btn_SubMenuRecta.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuRecta.TabIndex = 4;
            this.Btn_SubMenuRecta.Text = "Recta";
            this.Btn_SubMenuRecta.UseVisualStyleBackColor = false;
            this.Btn_SubMenuRecta.Click += new System.EventHandler(this.Btn_SubMenuRecta_Click);
            // 
            // Btn_DibujarEcuaciones
            // 
            this.Btn_DibujarEcuaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(111)))), ((int)(((byte)(185)))));
            this.Btn_DibujarEcuaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_DibujarEcuaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Btn_DibujarEcuaciones.FlatAppearance.BorderSize = 0;
            this.Btn_DibujarEcuaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DibujarEcuaciones.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_DibujarEcuaciones.ForeColor = System.Drawing.Color.White;
            this.Btn_DibujarEcuaciones.Location = new System.Drawing.Point(0, 2053);
            this.Btn_DibujarEcuaciones.Name = "Btn_DibujarEcuaciones";
            this.Btn_DibujarEcuaciones.Size = new System.Drawing.Size(283, 40);
            this.Btn_DibujarEcuaciones.TabIndex = 20;
            this.Btn_DibujarEcuaciones.Text = "Ecuaciones";
            this.Btn_DibujarEcuaciones.UseVisualStyleBackColor = false;
            // 
            // Panel_DibujarFiguras
            // 
            this.Panel_DibujarFiguras.AutoSize = true;
            this.Panel_DibujarFiguras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.Panel_DibujarFiguras.Controls.Add(this.Panel_SubMenuDibujarCuadrado);
            this.Panel_DibujarFiguras.Controls.Add(this.Btn_SubMenuCuadrado);
            this.Panel_DibujarFiguras.Controls.Add(this.Panel_SubMenuDibujarTriangulo);
            this.Panel_DibujarFiguras.Controls.Add(this.Btn_SubMenuTriangulo);
            this.Panel_DibujarFiguras.Controls.Add(this.Panel_SubMenuDibujarCirculo);
            this.Panel_DibujarFiguras.Controls.Add(this.Btn_SubMenuCirculo);
            this.Panel_DibujarFiguras.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_DibujarFiguras.Location = new System.Drawing.Point(0, 1195);
            this.Panel_DibujarFiguras.Name = "Panel_DibujarFiguras";
            this.Panel_DibujarFiguras.Size = new System.Drawing.Size(283, 858);
            this.Panel_DibujarFiguras.TabIndex = 10;
            this.Panel_DibujarFiguras.Visible = false;
            // 
            // Panel_SubMenuDibujarCuadrado
            // 
            this.Panel_SubMenuDibujarCuadrado.AutoSize = true;
            this.Panel_SubMenuDibujarCuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.Panel_SubMenuDibujarCuadrado.Controls.Add(this.Panel_Cuadrado);
            this.Panel_SubMenuDibujarCuadrado.Controls.Add(this.Panel_CuadradoDibujar);
            this.Panel_SubMenuDibujarCuadrado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SubMenuDibujarCuadrado.Location = new System.Drawing.Point(0, 574);
            this.Panel_SubMenuDibujarCuadrado.Name = "Panel_SubMenuDibujarCuadrado";
            this.Panel_SubMenuDibujarCuadrado.Size = new System.Drawing.Size(283, 284);
            this.Panel_SubMenuDibujarCuadrado.TabIndex = 13;
            this.Panel_SubMenuDibujarCuadrado.Visible = false;
            // 
            // Panel_Cuadrado
            // 
            this.Panel_Cuadrado.Controls.Add(this.Btn_DibujarFigurasCuadrado);
            this.Panel_Cuadrado.Controls.Add(this.groupBox13);
            this.Panel_Cuadrado.Controls.Add(this.groupBox14);
            this.Panel_Cuadrado.Controls.Add(this.label73);
            this.Panel_Cuadrado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Cuadrado.Location = new System.Drawing.Point(0, 0);
            this.Panel_Cuadrado.Name = "Panel_Cuadrado";
            this.Panel_Cuadrado.Size = new System.Drawing.Size(283, 174);
            this.Panel_Cuadrado.TabIndex = 44;
            // 
            // Btn_DibujarFigurasCuadrado
            // 
            this.Btn_DibujarFigurasCuadrado.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_DibujarFigurasCuadrado.Location = new System.Drawing.Point(107, 140);
            this.Btn_DibujarFigurasCuadrado.Name = "Btn_DibujarFigurasCuadrado";
            this.Btn_DibujarFigurasCuadrado.Size = new System.Drawing.Size(68, 26);
            this.Btn_DibujarFigurasCuadrado.TabIndex = 46;
            this.Btn_DibujarFigurasCuadrado.Text = "Dibujar";
            this.Btn_DibujarFigurasCuadrado.UseVisualStyleBackColor = true;
            this.Btn_DibujarFigurasCuadrado.Click += new System.EventHandler(this.Btn_DibujarFigurasCuadrado_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtCuadradoPuntoBy);
            this.groupBox13.Controls.Add(this.label53);
            this.groupBox13.Controls.Add(this.label54);
            this.groupBox13.Controls.Add(this.txtCuadradoPuntoBx);
            this.groupBox13.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox13.Location = new System.Drawing.Point(151, 37);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(123, 88);
            this.groupBox13.TabIndex = 45;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Punto B";
            // 
            // txtCuadradoPuntoBy
            // 
            this.txtCuadradoPuntoBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtCuadradoPuntoBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuadradoPuntoBy.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtCuadradoPuntoBy.Location = new System.Drawing.Point(48, 59);
            this.txtCuadradoPuntoBy.Name = "txtCuadradoPuntoBy";
            this.txtCuadradoPuntoBy.Size = new System.Drawing.Size(35, 19);
            this.txtCuadradoPuntoBy.TabIndex = 17;
            this.txtCuadradoPuntoBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label53.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label53.Location = new System.Drawing.Point(13, 31);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(18, 17);
            this.label53.TabIndex = 14;
            this.label53.Text = "X:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label54.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label54.Location = new System.Drawing.Point(13, 59);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(17, 17);
            this.label54.TabIndex = 15;
            this.label54.Text = "Y:";
            // 
            // txtCuadradoPuntoBx
            // 
            this.txtCuadradoPuntoBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtCuadradoPuntoBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuadradoPuntoBx.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtCuadradoPuntoBx.Location = new System.Drawing.Point(48, 31);
            this.txtCuadradoPuntoBx.Name = "txtCuadradoPuntoBx";
            this.txtCuadradoPuntoBx.Size = new System.Drawing.Size(35, 19);
            this.txtCuadradoPuntoBx.TabIndex = 16;
            this.txtCuadradoPuntoBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txtCuadradoPuntoAy);
            this.groupBox14.Controls.Add(this.label55);
            this.groupBox14.Controls.Add(this.txtCuadradoPuntoAx);
            this.groupBox14.Controls.Add(this.label56);
            this.groupBox14.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox14.Location = new System.Drawing.Point(8, 37);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(123, 88);
            this.groupBox14.TabIndex = 44;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Punto A";
            // 
            // txtCuadradoPuntoAy
            // 
            this.txtCuadradoPuntoAy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtCuadradoPuntoAy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuadradoPuntoAy.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtCuadradoPuntoAy.Location = new System.Drawing.Point(57, 59);
            this.txtCuadradoPuntoAy.Name = "txtCuadradoPuntoAy";
            this.txtCuadradoPuntoAy.Size = new System.Drawing.Size(35, 19);
            this.txtCuadradoPuntoAy.TabIndex = 13;
            this.txtCuadradoPuntoAy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label55.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label55.Location = new System.Drawing.Point(22, 31);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(18, 17);
            this.label55.TabIndex = 10;
            this.label55.Text = "X:";
            // 
            // txtCuadradoPuntoAx
            // 
            this.txtCuadradoPuntoAx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtCuadradoPuntoAx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuadradoPuntoAx.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtCuadradoPuntoAx.Location = new System.Drawing.Point(57, 31);
            this.txtCuadradoPuntoAx.Name = "txtCuadradoPuntoAx";
            this.txtCuadradoPuntoAx.Size = new System.Drawing.Size(35, 19);
            this.txtCuadradoPuntoAx.TabIndex = 12;
            this.txtCuadradoPuntoAx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label56.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label56.Location = new System.Drawing.Point(22, 59);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(17, 17);
            this.label56.TabIndex = 11;
            this.label56.Text = "Y:";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label73.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label73.Location = new System.Drawing.Point(84, 9);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(108, 17);
            this.label73.TabIndex = 43;
            this.label73.Text = "Seleccione puntos:";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_CuadradoDibujar
            // 
            this.Panel_CuadradoDibujar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.Panel_CuadradoDibujar.Controls.Add(this.lblAlturaCuadrado);
            this.Panel_CuadradoDibujar.Controls.Add(this.lblBaseCuadrado);
            this.Panel_CuadradoDibujar.Controls.Add(this.label60);
            this.Panel_CuadradoDibujar.Controls.Add(this.label59);
            this.Panel_CuadradoDibujar.Controls.Add(this.lblAreaCuadrado);
            this.Panel_CuadradoDibujar.Controls.Add(this.lblPerimetroCuadrado);
            this.Panel_CuadradoDibujar.Controls.Add(this.label58);
            this.Panel_CuadradoDibujar.Controls.Add(this.label57);
            this.Panel_CuadradoDibujar.Controls.Add(this.label71);
            this.Panel_CuadradoDibujar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_CuadradoDibujar.Location = new System.Drawing.Point(0, 174);
            this.Panel_CuadradoDibujar.Name = "Panel_CuadradoDibujar";
            this.Panel_CuadradoDibujar.Size = new System.Drawing.Size(283, 110);
            this.Panel_CuadradoDibujar.TabIndex = 43;
            this.Panel_CuadradoDibujar.Visible = false;
            // 
            // lblAlturaCuadrado
            // 
            this.lblAlturaCuadrado.AutoSize = true;
            this.lblAlturaCuadrado.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblAlturaCuadrado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAlturaCuadrado.Location = new System.Drawing.Point(193, 30);
            this.lblAlturaCuadrado.Name = "lblAlturaCuadrado";
            this.lblAlturaCuadrado.Size = new System.Drawing.Size(41, 17);
            this.lblAlturaCuadrado.TabIndex = 48;
            this.lblAlturaCuadrado.Text = "Altura";
            this.lblAlturaCuadrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlturaCuadrado.Visible = false;
            // 
            // lblBaseCuadrado
            // 
            this.lblBaseCuadrado.AutoSize = true;
            this.lblBaseCuadrado.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblBaseCuadrado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaseCuadrado.Location = new System.Drawing.Point(81, 30);
            this.lblBaseCuadrado.Name = "lblBaseCuadrado";
            this.lblBaseCuadrado.Size = new System.Drawing.Size(34, 17);
            this.lblBaseCuadrado.TabIndex = 47;
            this.lblBaseCuadrado.Text = "Base";
            this.lblBaseCuadrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBaseCuadrado.Visible = false;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label60.Location = new System.Drawing.Point(143, 30);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(47, 17);
            this.label60.TabIndex = 46;
            this.label60.Text = "Altura:";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label59.Location = new System.Drawing.Point(34, 30);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(40, 17);
            this.label59.TabIndex = 45;
            this.label59.Text = "Base:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAreaCuadrado
            // 
            this.lblAreaCuadrado.AutoSize = true;
            this.lblAreaCuadrado.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblAreaCuadrado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAreaCuadrado.Location = new System.Drawing.Point(114, 80);
            this.lblAreaCuadrado.Name = "lblAreaCuadrado";
            this.lblAreaCuadrado.Size = new System.Drawing.Size(36, 17);
            this.lblAreaCuadrado.TabIndex = 44;
            this.lblAreaCuadrado.Text = "Área:";
            this.lblAreaCuadrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAreaCuadrado.Visible = false;
            // 
            // lblPerimetroCuadrado
            // 
            this.lblPerimetroCuadrado.AutoSize = true;
            this.lblPerimetroCuadrado.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblPerimetroCuadrado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPerimetroCuadrado.Location = new System.Drawing.Point(114, 58);
            this.lblPerimetroCuadrado.Name = "lblPerimetroCuadrado";
            this.lblPerimetroCuadrado.Size = new System.Drawing.Size(65, 17);
            this.lblPerimetroCuadrado.TabIndex = 43;
            this.lblPerimetroCuadrado.Text = "Perímetro:";
            this.lblPerimetroCuadrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPerimetroCuadrado.Visible = false;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label58.Location = new System.Drawing.Point(15, 80);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(38, 17);
            this.label58.TabIndex = 42;
            this.label58.Text = "Área:";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label57.Location = new System.Drawing.Point(15, 58);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(70, 17);
            this.label57.TabIndex = 41;
            this.label57.Text = "Perímetro:";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label71.Location = new System.Drawing.Point(68, 10);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(141, 19);
            this.label71.TabIndex = 17;
            this.label71.Text = "Detalles de la figura:";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_SubMenuCuadrado
            // 
            this.Btn_SubMenuCuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.Btn_SubMenuCuadrado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuCuadrado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuCuadrado.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuCuadrado.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_SubMenuCuadrado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_SubMenuCuadrado.Location = new System.Drawing.Point(0, 544);
            this.Btn_SubMenuCuadrado.Name = "Btn_SubMenuCuadrado";
            this.Btn_SubMenuCuadrado.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuCuadrado.TabIndex = 5;
            this.Btn_SubMenuCuadrado.Text = "Cuadrado";
            this.Btn_SubMenuCuadrado.UseVisualStyleBackColor = false;
            this.Btn_SubMenuCuadrado.Click += new System.EventHandler(this.Btn_SubMenuCuadrado_Click);
            // 
            // Panel_SubMenuDibujarTriangulo
            // 
            this.Panel_SubMenuDibujarTriangulo.AutoSize = true;
            this.Panel_SubMenuDibujarTriangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.Panel_SubMenuDibujarTriangulo.Controls.Add(this.Panel_Triangulo);
            this.Panel_SubMenuDibujarTriangulo.Controls.Add(this.Panel_TrianguloDibujar);
            this.Panel_SubMenuDibujarTriangulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SubMenuDibujarTriangulo.Location = new System.Drawing.Point(0, 260);
            this.Panel_SubMenuDibujarTriangulo.Name = "Panel_SubMenuDibujarTriangulo";
            this.Panel_SubMenuDibujarTriangulo.Size = new System.Drawing.Size(283, 284);
            this.Panel_SubMenuDibujarTriangulo.TabIndex = 15;
            this.Panel_SubMenuDibujarTriangulo.Visible = false;
            // 
            // Panel_Triangulo
            // 
            this.Panel_Triangulo.Controls.Add(this.Btn_DibujarFigurasTriangulo);
            this.Panel_Triangulo.Controls.Add(this.groupBox15);
            this.Panel_Triangulo.Controls.Add(this.groupBox16);
            this.Panel_Triangulo.Controls.Add(this.label79);
            this.Panel_Triangulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Triangulo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Triangulo.Name = "Panel_Triangulo";
            this.Panel_Triangulo.Size = new System.Drawing.Size(283, 174);
            this.Panel_Triangulo.TabIndex = 44;
            // 
            // Btn_DibujarFigurasTriangulo
            // 
            this.Btn_DibujarFigurasTriangulo.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_DibujarFigurasTriangulo.Location = new System.Drawing.Point(107, 140);
            this.Btn_DibujarFigurasTriangulo.Name = "Btn_DibujarFigurasTriangulo";
            this.Btn_DibujarFigurasTriangulo.Size = new System.Drawing.Size(68, 26);
            this.Btn_DibujarFigurasTriangulo.TabIndex = 46;
            this.Btn_DibujarFigurasTriangulo.Text = "Dibujar";
            this.Btn_DibujarFigurasTriangulo.UseVisualStyleBackColor = true;
            this.Btn_DibujarFigurasTriangulo.Click += new System.EventHandler(this.Btn_DibujarFigurasTriangulo_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.txtTrianguloBy);
            this.groupBox15.Controls.Add(this.label70);
            this.groupBox15.Controls.Add(this.label72);
            this.groupBox15.Controls.Add(this.txtTrianguloBx);
            this.groupBox15.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox15.Location = new System.Drawing.Point(151, 37);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(123, 88);
            this.groupBox15.TabIndex = 45;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Punto B";
            // 
            // txtTrianguloBy
            // 
            this.txtTrianguloBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtTrianguloBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrianguloBy.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtTrianguloBy.Location = new System.Drawing.Point(48, 59);
            this.txtTrianguloBy.Name = "txtTrianguloBy";
            this.txtTrianguloBy.Size = new System.Drawing.Size(53, 19);
            this.txtTrianguloBy.TabIndex = 17;
            this.txtTrianguloBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label70.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label70.Location = new System.Drawing.Point(13, 31);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(18, 17);
            this.label70.TabIndex = 14;
            this.label70.Text = "X:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label72.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label72.Location = new System.Drawing.Point(13, 59);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(17, 17);
            this.label72.TabIndex = 15;
            this.label72.Text = "Y:";
            // 
            // txtTrianguloBx
            // 
            this.txtTrianguloBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtTrianguloBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrianguloBx.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtTrianguloBx.Location = new System.Drawing.Point(48, 31);
            this.txtTrianguloBx.Name = "txtTrianguloBx";
            this.txtTrianguloBx.Size = new System.Drawing.Size(53, 19);
            this.txtTrianguloBx.TabIndex = 16;
            this.txtTrianguloBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.txtTrianguloAy);
            this.groupBox16.Controls.Add(this.label77);
            this.groupBox16.Controls.Add(this.txtTrianguloAx);
            this.groupBox16.Controls.Add(this.label78);
            this.groupBox16.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox16.Location = new System.Drawing.Point(8, 37);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(123, 88);
            this.groupBox16.TabIndex = 44;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Punto A";
            // 
            // txtTrianguloAy
            // 
            this.txtTrianguloAy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtTrianguloAy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrianguloAy.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtTrianguloAy.Location = new System.Drawing.Point(57, 59);
            this.txtTrianguloAy.Name = "txtTrianguloAy";
            this.txtTrianguloAy.Size = new System.Drawing.Size(53, 19);
            this.txtTrianguloAy.TabIndex = 13;
            this.txtTrianguloAy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label77.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label77.Location = new System.Drawing.Point(22, 31);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(18, 17);
            this.label77.TabIndex = 10;
            this.label77.Text = "X:";
            // 
            // txtTrianguloAx
            // 
            this.txtTrianguloAx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtTrianguloAx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrianguloAx.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtTrianguloAx.Location = new System.Drawing.Point(57, 31);
            this.txtTrianguloAx.Name = "txtTrianguloAx";
            this.txtTrianguloAx.Size = new System.Drawing.Size(53, 19);
            this.txtTrianguloAx.TabIndex = 12;
            this.txtTrianguloAx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label78.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label78.Location = new System.Drawing.Point(22, 59);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(17, 17);
            this.label78.TabIndex = 11;
            this.label78.Text = "Y:";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label79.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label79.Location = new System.Drawing.Point(84, 9);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(108, 17);
            this.label79.TabIndex = 43;
            this.label79.Text = "Seleccione puntos:";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_TrianguloDibujar
            // 
            this.Panel_TrianguloDibujar.Controls.Add(this.lblAlturaTriangulo);
            this.Panel_TrianguloDibujar.Controls.Add(this.lblBaseTriangulo);
            this.Panel_TrianguloDibujar.Controls.Add(this.label63);
            this.Panel_TrianguloDibujar.Controls.Add(this.label64);
            this.Panel_TrianguloDibujar.Controls.Add(this.lblAreaTriangulo);
            this.Panel_TrianguloDibujar.Controls.Add(this.lblPerimetroTriangulo);
            this.Panel_TrianguloDibujar.Controls.Add(this.label67);
            this.Panel_TrianguloDibujar.Controls.Add(this.label68);
            this.Panel_TrianguloDibujar.Controls.Add(this.label69);
            this.Panel_TrianguloDibujar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_TrianguloDibujar.Location = new System.Drawing.Point(0, 174);
            this.Panel_TrianguloDibujar.Name = "Panel_TrianguloDibujar";
            this.Panel_TrianguloDibujar.Size = new System.Drawing.Size(283, 110);
            this.Panel_TrianguloDibujar.TabIndex = 43;
            this.Panel_TrianguloDibujar.Visible = false;
            // 
            // lblAlturaTriangulo
            // 
            this.lblAlturaTriangulo.AutoSize = true;
            this.lblAlturaTriangulo.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblAlturaTriangulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAlturaTriangulo.Location = new System.Drawing.Point(193, 30);
            this.lblAlturaTriangulo.Name = "lblAlturaTriangulo";
            this.lblAlturaTriangulo.Size = new System.Drawing.Size(41, 17);
            this.lblAlturaTriangulo.TabIndex = 48;
            this.lblAlturaTriangulo.Text = "Altura";
            this.lblAlturaTriangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlturaTriangulo.Visible = false;
            // 
            // lblBaseTriangulo
            // 
            this.lblBaseTriangulo.AutoSize = true;
            this.lblBaseTriangulo.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblBaseTriangulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaseTriangulo.Location = new System.Drawing.Point(81, 30);
            this.lblBaseTriangulo.Name = "lblBaseTriangulo";
            this.lblBaseTriangulo.Size = new System.Drawing.Size(34, 17);
            this.lblBaseTriangulo.TabIndex = 47;
            this.lblBaseTriangulo.Text = "Base";
            this.lblBaseTriangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBaseTriangulo.Visible = false;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label63.Location = new System.Drawing.Point(143, 30);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(47, 17);
            this.label63.TabIndex = 46;
            this.label63.Text = "Altura:";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label64.Location = new System.Drawing.Point(34, 30);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(40, 17);
            this.label64.TabIndex = 45;
            this.label64.Text = "Base:";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAreaTriangulo
            // 
            this.lblAreaTriangulo.AutoSize = true;
            this.lblAreaTriangulo.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblAreaTriangulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAreaTriangulo.Location = new System.Drawing.Point(114, 80);
            this.lblAreaTriangulo.Name = "lblAreaTriangulo";
            this.lblAreaTriangulo.Size = new System.Drawing.Size(36, 17);
            this.lblAreaTriangulo.TabIndex = 44;
            this.lblAreaTriangulo.Text = "Área:";
            this.lblAreaTriangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAreaTriangulo.Visible = false;
            // 
            // lblPerimetroTriangulo
            // 
            this.lblPerimetroTriangulo.AutoSize = true;
            this.lblPerimetroTriangulo.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblPerimetroTriangulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPerimetroTriangulo.Location = new System.Drawing.Point(114, 58);
            this.lblPerimetroTriangulo.Name = "lblPerimetroTriangulo";
            this.lblPerimetroTriangulo.Size = new System.Drawing.Size(65, 17);
            this.lblPerimetroTriangulo.TabIndex = 43;
            this.lblPerimetroTriangulo.Text = "Perímetro:";
            this.lblPerimetroTriangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPerimetroTriangulo.Visible = false;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label67.Location = new System.Drawing.Point(15, 80);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(38, 17);
            this.label67.TabIndex = 42;
            this.label67.Text = "Área:";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label68.Location = new System.Drawing.Point(15, 58);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(70, 17);
            this.label68.TabIndex = 41;
            this.label68.Text = "Perímetro:";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label69.Location = new System.Drawing.Point(68, 10);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(141, 19);
            this.label69.TabIndex = 17;
            this.label69.Text = "Detalles de la figura:";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_SubMenuTriangulo
            // 
            this.Btn_SubMenuTriangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.Btn_SubMenuTriangulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuTriangulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuTriangulo.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuTriangulo.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_SubMenuTriangulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_SubMenuTriangulo.Location = new System.Drawing.Point(0, 230);
            this.Btn_SubMenuTriangulo.Name = "Btn_SubMenuTriangulo";
            this.Btn_SubMenuTriangulo.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuTriangulo.TabIndex = 14;
            this.Btn_SubMenuTriangulo.Text = "Triángulo";
            this.Btn_SubMenuTriangulo.UseVisualStyleBackColor = false;
            this.Btn_SubMenuTriangulo.Click += new System.EventHandler(this.Btn_SubMenuTriangulo_Click);
            // 
            // Panel_SubMenuDibujarCirculo
            // 
            this.Panel_SubMenuDibujarCirculo.AutoSize = true;
            this.Panel_SubMenuDibujarCirculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.Panel_SubMenuDibujarCirculo.Controls.Add(this.Panel_DatosCirculo);
            this.Panel_SubMenuDibujarCirculo.Controls.Add(this.Panel_ResultadoCirculo);
            this.Panel_SubMenuDibujarCirculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SubMenuDibujarCirculo.Location = new System.Drawing.Point(0, 30);
            this.Panel_SubMenuDibujarCirculo.Name = "Panel_SubMenuDibujarCirculo";
            this.Panel_SubMenuDibujarCirculo.Size = new System.Drawing.Size(283, 200);
            this.Panel_SubMenuDibujarCirculo.TabIndex = 45;
            this.Panel_SubMenuDibujarCirculo.Visible = false;
            // 
            // Panel_DatosCirculo
            // 
            this.Panel_DatosCirculo.Controls.Add(this.txtRadioCirculo);
            this.Panel_DatosCirculo.Controls.Add(this.label65);
            this.Panel_DatosCirculo.Controls.Add(this.Btn_DibujarCirculo);
            this.Panel_DatosCirculo.Controls.Add(this.label82);
            this.Panel_DatosCirculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_DatosCirculo.Location = new System.Drawing.Point(0, 0);
            this.Panel_DatosCirculo.Name = "Panel_DatosCirculo";
            this.Panel_DatosCirculo.Size = new System.Drawing.Size(283, 110);
            this.Panel_DatosCirculo.TabIndex = 44;
            // 
            // txtRadioCirculo
            // 
            this.txtRadioCirculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtRadioCirculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRadioCirculo.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtRadioCirculo.Location = new System.Drawing.Point(158, 43);
            this.txtRadioCirculo.Name = "txtRadioCirculo";
            this.txtRadioCirculo.Size = new System.Drawing.Size(53, 19);
            this.txtRadioCirculo.TabIndex = 14;
            this.txtRadioCirculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label65.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label65.Location = new System.Drawing.Point(44, 45);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(42, 17);
            this.label65.TabIndex = 47;
            this.label65.Text = "Radio:";
            // 
            // Btn_DibujarCirculo
            // 
            this.Btn_DibujarCirculo.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_DibujarCirculo.Location = new System.Drawing.Point(102, 75);
            this.Btn_DibujarCirculo.Name = "Btn_DibujarCirculo";
            this.Btn_DibujarCirculo.Size = new System.Drawing.Size(68, 26);
            this.Btn_DibujarCirculo.TabIndex = 46;
            this.Btn_DibujarCirculo.Text = "Dibujar";
            this.Btn_DibujarCirculo.UseVisualStyleBackColor = true;
            this.Btn_DibujarCirculo.Click += new System.EventHandler(this.Btn_DibujarCirculo_Click);
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label82.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label82.Location = new System.Drawing.Point(99, 13);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(83, 17);
            this.label82.TabIndex = 43;
            this.label82.Text = "Ingrese datos:";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_ResultadoCirculo
            // 
            this.Panel_ResultadoCirculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.Panel_ResultadoCirculo.Controls.Add(this.lblAreaCirculo);
            this.Panel_ResultadoCirculo.Controls.Add(this.lblPerimetroCirculo);
            this.Panel_ResultadoCirculo.Controls.Add(this.label89);
            this.Panel_ResultadoCirculo.Controls.Add(this.label90);
            this.Panel_ResultadoCirculo.Controls.Add(this.label91);
            this.Panel_ResultadoCirculo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_ResultadoCirculo.Location = new System.Drawing.Point(0, 110);
            this.Panel_ResultadoCirculo.Name = "Panel_ResultadoCirculo";
            this.Panel_ResultadoCirculo.Size = new System.Drawing.Size(283, 90);
            this.Panel_ResultadoCirculo.TabIndex = 43;
            this.Panel_ResultadoCirculo.Visible = false;
            // 
            // lblAreaCirculo
            // 
            this.lblAreaCirculo.AutoSize = true;
            this.lblAreaCirculo.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblAreaCirculo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAreaCirculo.Location = new System.Drawing.Point(118, 60);
            this.lblAreaCirculo.Name = "lblAreaCirculo";
            this.lblAreaCirculo.Size = new System.Drawing.Size(36, 17);
            this.lblAreaCirculo.TabIndex = 44;
            this.lblAreaCirculo.Text = "Área:";
            this.lblAreaCirculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerimetroCirculo
            // 
            this.lblPerimetroCirculo.AutoSize = true;
            this.lblPerimetroCirculo.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblPerimetroCirculo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPerimetroCirculo.Location = new System.Drawing.Point(118, 38);
            this.lblPerimetroCirculo.Name = "lblPerimetroCirculo";
            this.lblPerimetroCirculo.Size = new System.Drawing.Size(65, 17);
            this.lblPerimetroCirculo.TabIndex = 43;
            this.lblPerimetroCirculo.Text = "Perímetro:";
            this.lblPerimetroCirculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label89.Location = new System.Drawing.Point(19, 60);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(38, 17);
            this.label89.TabIndex = 42;
            this.label89.Text = "Área:";
            this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label90.Location = new System.Drawing.Point(19, 38);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(70, 17);
            this.label90.TabIndex = 41;
            this.label90.Text = "Perímetro:";
            this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label91.Location = new System.Drawing.Point(68, 10);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(141, 19);
            this.label91.TabIndex = 17;
            this.label91.Text = "Detalles de la figura:";
            this.label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_SubMenuCirculo
            // 
            this.Btn_SubMenuCirculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.Btn_SubMenuCirculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuCirculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuCirculo.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuCirculo.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_SubMenuCirculo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_SubMenuCirculo.Location = new System.Drawing.Point(0, 0);
            this.Btn_SubMenuCirculo.Name = "Btn_SubMenuCirculo";
            this.Btn_SubMenuCirculo.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuCirculo.TabIndex = 16;
            this.Btn_SubMenuCirculo.Text = "Circunferencia";
            this.Btn_SubMenuCirculo.UseVisualStyleBackColor = false;
            this.Btn_SubMenuCirculo.Click += new System.EventHandler(this.Btn_SubMenuCirculo_Click);
            // 
            // Btn_DibujarFiguras
            // 
            this.Btn_DibujarFiguras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(111)))), ((int)(((byte)(185)))));
            this.Btn_DibujarFiguras.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_DibujarFiguras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Btn_DibujarFiguras.FlatAppearance.BorderSize = 0;
            this.Btn_DibujarFiguras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DibujarFiguras.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_DibujarFiguras.ForeColor = System.Drawing.Color.White;
            this.Btn_DibujarFiguras.Location = new System.Drawing.Point(0, 1155);
            this.Btn_DibujarFiguras.Name = "Btn_DibujarFiguras";
            this.Btn_DibujarFiguras.Size = new System.Drawing.Size(283, 40);
            this.Btn_DibujarFiguras.TabIndex = 10;
            this.Btn_DibujarFiguras.Text = "Figuras";
            this.Btn_DibujarFiguras.UseVisualStyleBackColor = false;
            this.Btn_DibujarFiguras.Click += new System.EventHandler(this.Btn_MenuEcuaciones_Click);
            // 
            // Panel_MenuDibujarOrigen
            // 
            this.Panel_MenuDibujarOrigen.AutoSize = true;
            this.Panel_MenuDibujarOrigen.Controls.Add(this.PanelSubMenuOperations);
            this.Panel_MenuDibujarOrigen.Controls.Add(this.BtnMenuOperations);
            this.Panel_MenuDibujarOrigen.Controls.Add(this.Panel_SubMenuDibujar);
            this.Panel_MenuDibujarOrigen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_MenuDibujarOrigen.Location = new System.Drawing.Point(0, 40);
            this.Panel_MenuDibujarOrigen.Name = "Panel_MenuDibujarOrigen";
            this.Panel_MenuDibujarOrigen.Size = new System.Drawing.Size(283, 1115);
            this.Panel_MenuDibujarOrigen.TabIndex = 1;
            this.Panel_MenuDibujarOrigen.Visible = false;
            // 
            // PanelSubMenuOperations
            // 
            this.PanelSubMenuOperations.AutoSize = true;
            this.PanelSubMenuOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.PanelSubMenuOperations.Controls.Add(this.PanelSubMenuOperationsProducto);
            this.PanelSubMenuOperations.Controls.Add(this.Btn_SubMenuOperationsProducto);
            this.PanelSubMenuOperations.Controls.Add(this.PanelSubMenuOperationsResta);
            this.PanelSubMenuOperations.Controls.Add(this.Btn_SubMenuOperationsResta);
            this.PanelSubMenuOperations.Controls.Add(this.PanelSubMenuOperationsSuma);
            this.PanelSubMenuOperations.Controls.Add(this.Btn_SubMenuOperationsSuma);
            this.PanelSubMenuOperations.Controls.Add(this.PanelSubMenuOperationsSentido);
            this.PanelSubMenuOperations.Controls.Add(this.Btn_SubMenuOperationsSentido);
            this.PanelSubMenuOperations.Controls.Add(this.PanelSubMenuOperationsEscalar);
            this.PanelSubMenuOperations.Controls.Add(this.Btn_SubMenuOperationsEscalar);
            this.PanelSubMenuOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperations.Location = new System.Drawing.Point(0, 130);
            this.PanelSubMenuOperations.Name = "PanelSubMenuOperations";
            this.PanelSubMenuOperations.Size = new System.Drawing.Size(283, 985);
            this.PanelSubMenuOperations.TabIndex = 6;
            // 
            // PanelSubMenuOperationsProducto
            // 
            this.PanelSubMenuOperationsProducto.AutoSize = true;
            this.PanelSubMenuOperationsProducto.Controls.Add(this.PanelProductoVector);
            this.PanelSubMenuOperationsProducto.Controls.Add(this.PanelProducto);
            this.PanelSubMenuOperationsProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperationsProducto.Enabled = false;
            this.PanelSubMenuOperationsProducto.Location = new System.Drawing.Point(0, 755);
            this.PanelSubMenuOperationsProducto.Name = "PanelSubMenuOperationsProducto";
            this.PanelSubMenuOperationsProducto.Size = new System.Drawing.Size(283, 230);
            this.PanelSubMenuOperationsProducto.TabIndex = 19;
            // 
            // PanelProductoVector
            // 
            this.PanelProductoVector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.PanelProductoVector.Controls.Add(this.lblResultadoProducto);
            this.PanelProductoVector.Controls.Add(this.label45);
            this.PanelProductoVector.Controls.Add(this.label44);
            this.PanelProductoVector.Controls.Add(this.label43);
            this.PanelProductoVector.Controls.Add(this.label34);
            this.PanelProductoVector.Controls.Add(this.label35);
            this.PanelProductoVector.Controls.Add(this.label38);
            this.PanelProductoVector.Controls.Add(this.lblProductoX2);
            this.PanelProductoVector.Controls.Add(this.lblProductoX1);
            this.PanelProductoVector.Controls.Add(this.label20);
            this.PanelProductoVector.Controls.Add(this.label40);
            this.PanelProductoVector.Controls.Add(this.label41);
            this.PanelProductoVector.Controls.Add(this.lblProductoY2);
            this.PanelProductoVector.Controls.Add(this.lblProductoY1);
            this.PanelProductoVector.Controls.Add(this.label21);
            this.PanelProductoVector.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProductoVector.Location = new System.Drawing.Point(0, 140);
            this.PanelProductoVector.Name = "PanelProductoVector";
            this.PanelProductoVector.Size = new System.Drawing.Size(283, 90);
            this.PanelProductoVector.TabIndex = 11;
            this.PanelProductoVector.Visible = false;
            // 
            // lblResultadoProducto
            // 
            this.lblResultadoProducto.AutoSize = true;
            this.lblResultadoProducto.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblResultadoProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblResultadoProducto.Location = new System.Drawing.Point(155, 65);
            this.lblResultadoProducto.Name = "lblResultadoProducto";
            this.lblResultadoProducto.Size = new System.Drawing.Size(14, 17);
            this.lblResultadoProducto.TabIndex = 34;
            this.lblResultadoProducto.Text = "x";
            this.lblResultadoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultadoProducto.Visible = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label45.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label45.Location = new System.Drawing.Point(77, 65);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(57, 17);
            this.label45.TabIndex = 33;
            this.label45.Text = "V1 * V2  =";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label44.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label44.Location = new System.Drawing.Point(19, 37);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(57, 17);
            this.label44.TabIndex = 32;
            this.label44.Text = "V1 * V2  =";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label43.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label43.Location = new System.Drawing.Point(170, 37);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(14, 17);
            this.label43.TabIndex = 31;
            this.label43.Text = "+";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label34.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label34.Location = new System.Drawing.Point(162, 37);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(12, 17);
            this.label34.TabIndex = 30;
            this.label34.Text = ")";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label35.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label35.Location = new System.Drawing.Point(77, 37);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(12, 17);
            this.label35.TabIndex = 29;
            this.label35.Text = "(";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label38.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label38.Location = new System.Drawing.Point(119, 37);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(13, 17);
            this.label38.TabIndex = 28;
            this.label38.Text = "*";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductoX2
            // 
            this.lblProductoX2.AutoSize = true;
            this.lblProductoX2.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblProductoX2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductoX2.Location = new System.Drawing.Point(138, 37);
            this.lblProductoX2.Name = "lblProductoX2";
            this.lblProductoX2.Size = new System.Drawing.Size(20, 17);
            this.lblProductoX2.TabIndex = 27;
            this.lblProductoX2.Text = "x2";
            this.lblProductoX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductoX2.Visible = false;
            // 
            // lblProductoX1
            // 
            this.lblProductoX1.AutoSize = true;
            this.lblProductoX1.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblProductoX1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductoX1.Location = new System.Drawing.Point(93, 37);
            this.lblProductoX1.Name = "lblProductoX1";
            this.lblProductoX1.Size = new System.Drawing.Size(20, 17);
            this.lblProductoX1.TabIndex = 26;
            this.lblProductoX1.Text = "x1";
            this.lblProductoX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductoX1.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Location = new System.Drawing.Point(260, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 17);
            this.label20.TabIndex = 25;
            this.label20.Text = ")";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label40.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label40.Location = new System.Drawing.Point(182, 37);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(12, 17);
            this.label40.TabIndex = 24;
            this.label40.Text = "(";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label41.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label41.Location = new System.Drawing.Point(219, 37);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(13, 17);
            this.label41.TabIndex = 23;
            this.label41.Text = "*";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductoY2
            // 
            this.lblProductoY2.AutoSize = true;
            this.lblProductoY2.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblProductoY2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductoY2.Location = new System.Drawing.Point(238, 37);
            this.lblProductoY2.Name = "lblProductoY2";
            this.lblProductoY2.Size = new System.Drawing.Size(20, 17);
            this.lblProductoY2.TabIndex = 22;
            this.lblProductoY2.Text = "y2";
            this.lblProductoY2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductoY2.Visible = false;
            // 
            // lblProductoY1
            // 
            this.lblProductoY1.AutoSize = true;
            this.lblProductoY1.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblProductoY1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductoY1.Location = new System.Drawing.Point(196, 37);
            this.lblProductoY1.Name = "lblProductoY1";
            this.lblProductoY1.Size = new System.Drawing.Size(20, 17);
            this.lblProductoY1.TabIndex = 21;
            this.lblProductoY1.Text = "y1";
            this.lblProductoY1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductoY1.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label21.Location = new System.Drawing.Point(50, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(170, 17);
            this.label21.TabIndex = 17;
            this.label21.Text = "El producto de los vectores es:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelProducto
            // 
            this.PanelProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.PanelProducto.Controls.Add(this.BtnCalcularProducto);
            this.PanelProducto.Controls.Add(this.groupBox4);
            this.PanelProducto.Controls.Add(this.groupBox5);
            this.PanelProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProducto.Enabled = false;
            this.PanelProducto.Location = new System.Drawing.Point(0, 0);
            this.PanelProducto.Name = "PanelProducto";
            this.PanelProducto.Size = new System.Drawing.Size(283, 140);
            this.PanelProducto.TabIndex = 10;
            // 
            // BtnCalcularProducto
            // 
            this.BtnCalcularProducto.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCalcularProducto.Location = new System.Drawing.Point(111, 103);
            this.BtnCalcularProducto.Name = "BtnCalcularProducto";
            this.BtnCalcularProducto.Size = new System.Drawing.Size(68, 26);
            this.BtnCalcularProducto.TabIndex = 24;
            this.BtnCalcularProducto.Text = "Calcular";
            this.BtnCalcularProducto.UseVisualStyleBackColor = true;
            this.BtnCalcularProducto.Click += new System.EventHandler(this.BtnCalcularProducto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtVectorProductoY2);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtVectorProductoX2);
            this.groupBox4.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Location = new System.Drawing.Point(157, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 88);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vector 2:";
            // 
            // txtVectorProductoY2
            // 
            this.txtVectorProductoY2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorProductoY2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorProductoY2.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtVectorProductoY2.Location = new System.Drawing.Point(48, 59);
            this.txtVectorProductoY2.Name = "txtVectorProductoY2";
            this.txtVectorProductoY2.Size = new System.Drawing.Size(35, 19);
            this.txtVectorProductoY2.TabIndex = 17;
            this.txtVectorProductoY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label22.Location = new System.Drawing.Point(13, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 17);
            this.label22.TabIndex = 14;
            this.label22.Text = "X:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label23.Location = new System.Drawing.Point(13, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 17);
            this.label23.TabIndex = 15;
            this.label23.Text = "Y:";
            // 
            // txtVectorProductoX2
            // 
            this.txtVectorProductoX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorProductoX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorProductoX2.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtVectorProductoX2.Location = new System.Drawing.Point(48, 31);
            this.txtVectorProductoX2.Name = "txtVectorProductoX2";
            this.txtVectorProductoX2.Size = new System.Drawing.Size(35, 19);
            this.txtVectorProductoX2.TabIndex = 16;
            this.txtVectorProductoX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtVectorProductoY1);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txtVectorProductoX1);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Location = new System.Drawing.Point(12, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 88);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vector 1:";
            // 
            // txtVectorProductoY1
            // 
            this.txtVectorProductoY1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorProductoY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorProductoY1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtVectorProductoY1.Location = new System.Drawing.Point(57, 59);
            this.txtVectorProductoY1.Name = "txtVectorProductoY1";
            this.txtVectorProductoY1.Size = new System.Drawing.Size(35, 19);
            this.txtVectorProductoY1.TabIndex = 13;
            this.txtVectorProductoY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label24.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label24.Location = new System.Drawing.Point(22, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 17);
            this.label24.TabIndex = 10;
            this.label24.Text = "X:";
            // 
            // txtVectorProductoX1
            // 
            this.txtVectorProductoX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorProductoX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorProductoX1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtVectorProductoX1.Location = new System.Drawing.Point(57, 31);
            this.txtVectorProductoX1.Name = "txtVectorProductoX1";
            this.txtVectorProductoX1.Size = new System.Drawing.Size(35, 19);
            this.txtVectorProductoX1.TabIndex = 12;
            this.txtVectorProductoX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label25.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label25.Location = new System.Drawing.Point(22, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 17);
            this.label25.TabIndex = 11;
            this.label25.Text = "Y:";
            // 
            // Btn_SubMenuOperationsProducto
            // 
            this.Btn_SubMenuOperationsProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.Btn_SubMenuOperationsProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuOperationsProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuOperationsProducto.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuOperationsProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuOperationsProducto.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_SubMenuOperationsProducto.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuOperationsProducto.Location = new System.Drawing.Point(0, 725);
            this.Btn_SubMenuOperationsProducto.Name = "Btn_SubMenuOperationsProducto";
            this.Btn_SubMenuOperationsProducto.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuOperationsProducto.TabIndex = 3;
            this.Btn_SubMenuOperationsProducto.Text = "Producto Punto";
            this.Btn_SubMenuOperationsProducto.UseVisualStyleBackColor = false;
            this.Btn_SubMenuOperationsProducto.Click += new System.EventHandler(this.Btn_SubMenuOperationsProducto_Click);
            // 
            // PanelSubMenuOperationsResta
            // 
            this.PanelSubMenuOperationsResta.AutoSize = true;
            this.PanelSubMenuOperationsResta.Controls.Add(this.PanelRestaVector);
            this.PanelSubMenuOperationsResta.Controls.Add(this.PanelResta);
            this.PanelSubMenuOperationsResta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperationsResta.Enabled = false;
            this.PanelSubMenuOperationsResta.Location = new System.Drawing.Point(0, 505);
            this.PanelSubMenuOperationsResta.Name = "PanelSubMenuOperationsResta";
            this.PanelSubMenuOperationsResta.Size = new System.Drawing.Size(283, 220);
            this.PanelSubMenuOperationsResta.TabIndex = 18;
            // 
            // PanelRestaVector
            // 
            this.PanelRestaVector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.PanelRestaVector.Controls.Add(this.label14);
            this.PanelRestaVector.Controls.Add(this.label36);
            this.PanelRestaVector.Controls.Add(this.label37);
            this.PanelRestaVector.Controls.Add(this.lblRestaY);
            this.PanelRestaVector.Controls.Add(this.lblRestaX);
            this.PanelRestaVector.Controls.Add(this.Btn_CalcularResta);
            this.PanelRestaVector.Controls.Add(this.label15);
            this.PanelRestaVector.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRestaVector.Location = new System.Drawing.Point(0, 140);
            this.PanelRestaVector.Name = "PanelRestaVector";
            this.PanelRestaVector.Size = new System.Drawing.Size(283, 80);
            this.PanelRestaVector.TabIndex = 11;
            this.PanelRestaVector.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(117, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = ")";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label36.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label36.Location = new System.Drawing.Point(44, 44);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(12, 17);
            this.label36.TabIndex = 24;
            this.label36.Text = "(";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label37.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label37.Location = new System.Drawing.Point(82, 44);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(11, 17);
            this.label37.TabIndex = 23;
            this.label37.Text = ",";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRestaY
            // 
            this.lblRestaY.AutoSize = true;
            this.lblRestaY.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblRestaY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRestaY.Location = new System.Drawing.Point(99, 44);
            this.lblRestaY.Name = "lblRestaY";
            this.lblRestaY.Size = new System.Drawing.Size(14, 17);
            this.lblRestaY.TabIndex = 22;
            this.lblRestaY.Text = "y";
            this.lblRestaY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRestaY.Visible = false;
            // 
            // lblRestaX
            // 
            this.lblRestaX.AutoSize = true;
            this.lblRestaX.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.lblRestaX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRestaX.Location = new System.Drawing.Point(62, 44);
            this.lblRestaX.Name = "lblRestaX";
            this.lblRestaX.Size = new System.Drawing.Size(14, 17);
            this.lblRestaX.TabIndex = 21;
            this.lblRestaX.Text = "x";
            this.lblRestaX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRestaX.Visible = false;
            // 
            // Btn_CalcularResta
            // 
            this.Btn_CalcularResta.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_CalcularResta.Location = new System.Drawing.Point(176, 39);
            this.Btn_CalcularResta.Name = "Btn_CalcularResta";
            this.Btn_CalcularResta.Size = new System.Drawing.Size(64, 26);
            this.Btn_CalcularResta.TabIndex = 18;
            this.Btn_CalcularResta.Text = "Dibujar";
            this.Btn_CalcularResta.UseVisualStyleBackColor = true;
            this.Btn_CalcularResta.Click += new System.EventHandler(this.Btn_CalcularResta_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(60, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "La resta de los vectores es:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelResta
            // 
            this.PanelResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.PanelResta.Controls.Add(this.BtnCalcularResta);
            this.PanelResta.Controls.Add(this.groupBox2);
            this.PanelResta.Controls.Add(this.groupBox3);
            this.PanelResta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelResta.Enabled = false;
            this.PanelResta.Location = new System.Drawing.Point(0, 0);
            this.PanelResta.Name = "PanelResta";
            this.PanelResta.Size = new System.Drawing.Size(283, 140);
            this.PanelResta.TabIndex = 10;
            // 
            // BtnCalcularResta
            // 
            this.BtnCalcularResta.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCalcularResta.Location = new System.Drawing.Point(111, 103);
            this.BtnCalcularResta.Name = "BtnCalcularResta";
            this.BtnCalcularResta.Size = new System.Drawing.Size(68, 26);
            this.BtnCalcularResta.TabIndex = 24;
            this.BtnCalcularResta.Text = "Calcular";
            this.BtnCalcularResta.UseVisualStyleBackColor = true;
            this.BtnCalcularResta.Click += new System.EventHandler(this.BtnCalcularResta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVectorRestaY2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtVectorRestaX2);
            this.groupBox2.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(157, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 88);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vector 2:";
            // 
            // txtVectorRestaY2
            // 
            this.txtVectorRestaY2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorRestaY2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorRestaY2.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtVectorRestaY2.Location = new System.Drawing.Point(48, 59);
            this.txtVectorRestaY2.Name = "txtVectorRestaY2";
            this.txtVectorRestaY2.Size = new System.Drawing.Size(35, 19);
            this.txtVectorRestaY2.TabIndex = 17;
            this.txtVectorRestaY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(13, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "X:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(13, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 17);
            this.label17.TabIndex = 15;
            this.label17.Text = "Y:";
            // 
            // txtVectorRestaX2
            // 
            this.txtVectorRestaX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorRestaX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorRestaX2.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtVectorRestaX2.Location = new System.Drawing.Point(48, 31);
            this.txtVectorRestaX2.Name = "txtVectorRestaX2";
            this.txtVectorRestaX2.Size = new System.Drawing.Size(35, 19);
            this.txtVectorRestaX2.TabIndex = 16;
            this.txtVectorRestaX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVectorRestaY1);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtVectorRestaX1);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 88);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vector 1:";
            // 
            // txtVectorRestaY1
            // 
            this.txtVectorRestaY1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorRestaY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorRestaY1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtVectorRestaY1.Location = new System.Drawing.Point(57, 59);
            this.txtVectorRestaY1.Name = "txtVectorRestaY1";
            this.txtVectorRestaY1.Size = new System.Drawing.Size(35, 19);
            this.txtVectorRestaY1.TabIndex = 13;
            this.txtVectorRestaY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(22, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 17);
            this.label18.TabIndex = 10;
            this.label18.Text = "X:";
            // 
            // txtVectorRestaX1
            // 
            this.txtVectorRestaX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorRestaX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorRestaX1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtVectorRestaX1.Location = new System.Drawing.Point(57, 31);
            this.txtVectorRestaX1.Name = "txtVectorRestaX1";
            this.txtVectorRestaX1.Size = new System.Drawing.Size(35, 19);
            this.txtVectorRestaX1.TabIndex = 12;
            this.txtVectorRestaX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Source Sans Pro", 9.75F);
            this.label19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label19.Location = new System.Drawing.Point(22, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 17);
            this.label19.TabIndex = 11;
            this.label19.Text = "Y:";
            // 
            // Btn_SubMenuOperationsResta
            // 
            this.Btn_SubMenuOperationsResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.Btn_SubMenuOperationsResta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuOperationsResta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuOperationsResta.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuOperationsResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuOperationsResta.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_SubMenuOperationsResta.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuOperationsResta.Location = new System.Drawing.Point(0, 475);
            this.Btn_SubMenuOperationsResta.Name = "Btn_SubMenuOperationsResta";
            this.Btn_SubMenuOperationsResta.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuOperationsResta.TabIndex = 2;
            this.Btn_SubMenuOperationsResta.Text = "Restar vectores";
            this.Btn_SubMenuOperationsResta.UseVisualStyleBackColor = false;
            this.Btn_SubMenuOperationsResta.Click += new System.EventHandler(this.Btn_SubMenuOperationsResta_Click);
            // 
            // PanelSubMenuOperationsSuma
            // 
            this.PanelSubMenuOperationsSuma.AutoSize = true;
            this.PanelSubMenuOperationsSuma.Controls.Add(this.PanelSumaVector);
            this.PanelSubMenuOperationsSuma.Controls.Add(this.PanelSuma);
            this.PanelSubMenuOperationsSuma.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperationsSuma.Enabled = false;
            this.PanelSubMenuOperationsSuma.Location = new System.Drawing.Point(0, 255);
            this.PanelSubMenuOperationsSuma.Name = "PanelSubMenuOperationsSuma";
            this.PanelSubMenuOperationsSuma.Size = new System.Drawing.Size(283, 220);
            this.PanelSubMenuOperationsSuma.TabIndex = 17;
            // 
            // PanelSumaVector
            // 
            this.PanelSumaVector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.PanelSumaVector.Controls.Add(this.label12);
            this.PanelSumaVector.Controls.Add(this.label32);
            this.PanelSumaVector.Controls.Add(this.label33);
            this.PanelSumaVector.Controls.Add(this.lblSumaY);
            this.PanelSumaVector.Controls.Add(this.lblSumaX);
            this.PanelSumaVector.Controls.Add(this.Btn_CalcularSuma);
            this.PanelSumaVector.Controls.Add(this.label13);
            this.PanelSumaVector.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSumaVector.Location = new System.Drawing.Point(0, 140);
            this.PanelSumaVector.Name = "PanelSumaVector";
            this.PanelSumaVector.Size = new System.Drawing.Size(283, 80);
            this.PanelSumaVector.TabIndex = 11;
            this.PanelSumaVector.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(117, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = ")";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label32.Location = new System.Drawing.Point(44, 44);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(12, 17);
            this.label32.TabIndex = 24;
            this.label32.Text = "(";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label33.Location = new System.Drawing.Point(82, 44);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(11, 17);
            this.label33.TabIndex = 23;
            this.label33.Text = ",";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumaY
            // 
            this.lblSumaY.AutoSize = true;
            this.lblSumaY.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSumaY.Location = new System.Drawing.Point(99, 44);
            this.lblSumaY.Name = "lblSumaY";
            this.lblSumaY.Size = new System.Drawing.Size(14, 17);
            this.lblSumaY.TabIndex = 22;
            this.lblSumaY.Text = "y";
            this.lblSumaY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSumaY.Visible = false;
            // 
            // lblSumaX
            // 
            this.lblSumaX.AutoSize = true;
            this.lblSumaX.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSumaX.Location = new System.Drawing.Point(62, 44);
            this.lblSumaX.Name = "lblSumaX";
            this.lblSumaX.Size = new System.Drawing.Size(14, 17);
            this.lblSumaX.TabIndex = 21;
            this.lblSumaX.Text = "x";
            this.lblSumaX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSumaX.Visible = false;
            // 
            // Btn_CalcularSuma
            // 
            this.Btn_CalcularSuma.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_CalcularSuma.Location = new System.Drawing.Point(176, 39);
            this.Btn_CalcularSuma.Name = "Btn_CalcularSuma";
            this.Btn_CalcularSuma.Size = new System.Drawing.Size(64, 26);
            this.Btn_CalcularSuma.TabIndex = 18;
            this.Btn_CalcularSuma.Text = "Dibujar";
            this.Btn_CalcularSuma.UseVisualStyleBackColor = true;
            this.Btn_CalcularSuma.Click += new System.EventHandler(this.Btn_CalcularSuma_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(58, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "La suma de los vectores es:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelSuma
            // 
            this.PanelSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.PanelSuma.Controls.Add(this.BtnCalcularSuma);
            this.PanelSuma.Controls.Add(this.groupBox6);
            this.PanelSuma.Controls.Add(this.groupBox7);
            this.PanelSuma.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuma.Enabled = false;
            this.PanelSuma.Location = new System.Drawing.Point(0, 0);
            this.PanelSuma.Name = "PanelSuma";
            this.PanelSuma.Size = new System.Drawing.Size(283, 140);
            this.PanelSuma.TabIndex = 10;
            // 
            // BtnCalcularSuma
            // 
            this.BtnCalcularSuma.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCalcularSuma.Location = new System.Drawing.Point(111, 103);
            this.BtnCalcularSuma.Name = "BtnCalcularSuma";
            this.BtnCalcularSuma.Size = new System.Drawing.Size(68, 26);
            this.BtnCalcularSuma.TabIndex = 24;
            this.BtnCalcularSuma.Text = "Calcular";
            this.BtnCalcularSuma.UseVisualStyleBackColor = true;
            this.BtnCalcularSuma.Click += new System.EventHandler(this.BtnCalcularSuma_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtSumaVectorY2);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.txtSumaVectorX2);
            this.groupBox6.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Location = new System.Drawing.Point(157, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(123, 88);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Vector 2:";
            // 
            // txtSumaVectorY2
            // 
            this.txtSumaVectorY2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtSumaVectorY2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumaVectorY2.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtSumaVectorY2.Location = new System.Drawing.Point(48, 59);
            this.txtSumaVectorY2.Name = "txtSumaVectorY2";
            this.txtSumaVectorY2.Size = new System.Drawing.Size(35, 19);
            this.txtSumaVectorY2.TabIndex = 17;
            this.txtSumaVectorY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label26.Location = new System.Drawing.Point(13, 31);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(18, 17);
            this.label26.TabIndex = 14;
            this.label26.Text = "X:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label27.Location = new System.Drawing.Point(13, 59);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(17, 17);
            this.label27.TabIndex = 15;
            this.label27.Text = "Y:";
            // 
            // txtSumaVectorX2
            // 
            this.txtSumaVectorX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtSumaVectorX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumaVectorX2.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtSumaVectorX2.Location = new System.Drawing.Point(48, 31);
            this.txtSumaVectorX2.Name = "txtSumaVectorX2";
            this.txtSumaVectorX2.Size = new System.Drawing.Size(35, 19);
            this.txtSumaVectorX2.TabIndex = 16;
            this.txtSumaVectorX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtSumaVectorY1);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.txtSumaVectorX1);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Location = new System.Drawing.Point(12, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(123, 88);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Vector 1:";
            // 
            // txtSumaVectorY1
            // 
            this.txtSumaVectorY1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtSumaVectorY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumaVectorY1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtSumaVectorY1.Location = new System.Drawing.Point(57, 59);
            this.txtSumaVectorY1.Name = "txtSumaVectorY1";
            this.txtSumaVectorY1.Size = new System.Drawing.Size(35, 19);
            this.txtSumaVectorY1.TabIndex = 13;
            this.txtSumaVectorY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label28.Location = new System.Drawing.Point(22, 31);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(18, 17);
            this.label28.TabIndex = 10;
            this.label28.Text = "X:";
            // 
            // txtSumaVectorX1
            // 
            this.txtSumaVectorX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtSumaVectorX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumaVectorX1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtSumaVectorX1.Location = new System.Drawing.Point(57, 31);
            this.txtSumaVectorX1.Name = "txtSumaVectorX1";
            this.txtSumaVectorX1.Size = new System.Drawing.Size(35, 19);
            this.txtSumaVectorX1.TabIndex = 12;
            this.txtSumaVectorX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label29.Location = new System.Drawing.Point(22, 59);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 17);
            this.label29.TabIndex = 11;
            this.label29.Text = "Y:";
            // 
            // Btn_SubMenuOperationsSuma
            // 
            this.Btn_SubMenuOperationsSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.Btn_SubMenuOperationsSuma.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuOperationsSuma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuOperationsSuma.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuOperationsSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuOperationsSuma.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_SubMenuOperationsSuma.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuOperationsSuma.Location = new System.Drawing.Point(0, 225);
            this.Btn_SubMenuOperationsSuma.Name = "Btn_SubMenuOperationsSuma";
            this.Btn_SubMenuOperationsSuma.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuOperationsSuma.TabIndex = 1;
            this.Btn_SubMenuOperationsSuma.Text = "Sumar vectores";
            this.Btn_SubMenuOperationsSuma.UseVisualStyleBackColor = false;
            this.Btn_SubMenuOperationsSuma.Click += new System.EventHandler(this.Btn_SubMenuOperationsSuma_Click);
            // 
            // PanelSubMenuOperationsSentido
            // 
            this.PanelSubMenuOperationsSentido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.PanelSubMenuOperationsSentido.Controls.Add(this.label31);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.label11);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.label5);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.lblVectorActualY_PnlCambiarSentido);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.BtnCambiarSentido);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.lblVectorActualX_PnlCambiarSentido);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.label10);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.checkBoxY);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.checkBoxX);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.label8);
            this.PanelSubMenuOperationsSentido.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperationsSentido.Location = new System.Drawing.Point(0, 125);
            this.PanelSubMenuOperationsSentido.Name = "PanelSubMenuOperationsSentido";
            this.PanelSubMenuOperationsSentido.Size = new System.Drawing.Size(283, 100);
            this.PanelSubMenuOperationsSentido.TabIndex = 6;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label31.Location = new System.Drawing.Point(167, 71);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(12, 17);
            this.label31.TabIndex = 20;
            this.label31.Text = ")";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(95, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "(";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(130, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = ",";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // lblVectorActualY_PnlCambiarSentido
            // 
            this.lblVectorActualY_PnlCambiarSentido.AutoSize = true;
            this.lblVectorActualY_PnlCambiarSentido.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectorActualY_PnlCambiarSentido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVectorActualY_PnlCambiarSentido.Location = new System.Drawing.Point(148, 71);
            this.lblVectorActualY_PnlCambiarSentido.Name = "lblVectorActualY_PnlCambiarSentido";
            this.lblVectorActualY_PnlCambiarSentido.Size = new System.Drawing.Size(14, 17);
            this.lblVectorActualY_PnlCambiarSentido.TabIndex = 17;
            this.lblVectorActualY_PnlCambiarSentido.Text = "y";
            this.lblVectorActualY_PnlCambiarSentido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVectorActualY_PnlCambiarSentido.Visible = false;
            // 
            // BtnCambiarSentido
            // 
            this.BtnCambiarSentido.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCambiarSentido.Location = new System.Drawing.Point(198, 66);
            this.BtnCambiarSentido.Name = "BtnCambiarSentido";
            this.BtnCambiarSentido.Size = new System.Drawing.Size(64, 26);
            this.BtnCambiarSentido.TabIndex = 15;
            this.BtnCambiarSentido.Text = "Dibujar";
            this.BtnCambiarSentido.UseVisualStyleBackColor = true;
            this.BtnCambiarSentido.Click += new System.EventHandler(this.BtnCambiarSentido_Click);
            // 
            // lblVectorActualX_PnlCambiarSentido
            // 
            this.lblVectorActualX_PnlCambiarSentido.AutoSize = true;
            this.lblVectorActualX_PnlCambiarSentido.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectorActualX_PnlCambiarSentido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVectorActualX_PnlCambiarSentido.Location = new System.Drawing.Point(111, 73);
            this.lblVectorActualX_PnlCambiarSentido.Name = "lblVectorActualX_PnlCambiarSentido";
            this.lblVectorActualX_PnlCambiarSentido.Size = new System.Drawing.Size(14, 17);
            this.lblVectorActualX_PnlCambiarSentido.TabIndex = 16;
            this.lblVectorActualX_PnlCambiarSentido.Text = "x";
            this.lblVectorActualX_PnlCambiarSentido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVectorActualX_PnlCambiarSentido.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(27, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Vector:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxY.Location = new System.Drawing.Point(173, 42);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(33, 21);
            this.checkBoxY.TabIndex = 14;
            this.checkBoxY.Text = "Y";
            this.checkBoxY.UseVisualStyleBackColor = true;
            this.checkBoxY.Click += new System.EventHandler(this.checkBoxY_Click);
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxX.Location = new System.Drawing.Point(91, 42);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(34, 21);
            this.checkBoxX.TabIndex = 13;
            this.checkBoxX.Text = "X";
            this.checkBoxX.UseVisualStyleBackColor = true;
            this.checkBoxX.Click += new System.EventHandler(this.checkBoxX_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(34, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Seleccionar eje a cambiar de sentido:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_SubMenuOperationsSentido
            // 
            this.Btn_SubMenuOperationsSentido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.Btn_SubMenuOperationsSentido.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuOperationsSentido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuOperationsSentido.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuOperationsSentido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuOperationsSentido.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_SubMenuOperationsSentido.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuOperationsSentido.Location = new System.Drawing.Point(0, 95);
            this.Btn_SubMenuOperationsSentido.Name = "Btn_SubMenuOperationsSentido";
            this.Btn_SubMenuOperationsSentido.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuOperationsSentido.TabIndex = 4;
            this.Btn_SubMenuOperationsSentido.Text = "Cambiar sentido";
            this.Btn_SubMenuOperationsSentido.UseVisualStyleBackColor = false;
            this.Btn_SubMenuOperationsSentido.Click += new System.EventHandler(this.Btn_SubMenuOperationsSentido_Click);
            // 
            // PanelSubMenuOperationsEscalar
            // 
            this.PanelSubMenuOperationsEscalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.PanelSubMenuOperationsEscalar.Controls.Add(this.lblVectorActual_PnlEscalar);
            this.PanelSubMenuOperationsEscalar.Controls.Add(this.BtnAplicarEscalar);
            this.PanelSubMenuOperationsEscalar.Controls.Add(this.label9);
            this.PanelSubMenuOperationsEscalar.Controls.Add(this.txtEscalar);
            this.PanelSubMenuOperationsEscalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperationsEscalar.Location = new System.Drawing.Point(0, 30);
            this.PanelSubMenuOperationsEscalar.Name = "PanelSubMenuOperationsEscalar";
            this.PanelSubMenuOperationsEscalar.Size = new System.Drawing.Size(283, 65);
            this.PanelSubMenuOperationsEscalar.TabIndex = 5;
            this.PanelSubMenuOperationsEscalar.Visible = false;
            // 
            // lblVectorActual_PnlEscalar
            // 
            this.lblVectorActual_PnlEscalar.AutoSize = true;
            this.lblVectorActual_PnlEscalar.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectorActual_PnlEscalar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVectorActual_PnlEscalar.Location = new System.Drawing.Point(121, 26);
            this.lblVectorActual_PnlEscalar.Name = "lblVectorActual_PnlEscalar";
            this.lblVectorActual_PnlEscalar.Size = new System.Drawing.Size(40, 19);
            this.lblVectorActual_PnlEscalar.TabIndex = 14;
            this.lblVectorActual_PnlEscalar.Text = "(x, y)";
            this.lblVectorActual_PnlEscalar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVectorActual_PnlEscalar.Visible = false;
            // 
            // BtnAplicarEscalar
            // 
            this.BtnAplicarEscalar.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnAplicarEscalar.Location = new System.Drawing.Point(197, 18);
            this.BtnAplicarEscalar.Name = "BtnAplicarEscalar";
            this.BtnAplicarEscalar.Size = new System.Drawing.Size(64, 33);
            this.BtnAplicarEscalar.TabIndex = 13;
            this.BtnAplicarEscalar.Text = "Aplicar";
            this.BtnAplicarEscalar.UseVisualStyleBackColor = true;
            this.BtnAplicarEscalar.Click += new System.EventHandler(this.BtnAplicarEscalar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(12, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Escalar:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEscalar
            // 
            this.txtEscalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtEscalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEscalar.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtEscalar.Location = new System.Drawing.Point(69, 26);
            this.txtEscalar.Name = "txtEscalar";
            this.txtEscalar.Size = new System.Drawing.Size(35, 19);
            this.txtEscalar.TabIndex = 12;
            this.txtEscalar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_SubMenuOperationsEscalar
            // 
            this.Btn_SubMenuOperationsEscalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.Btn_SubMenuOperationsEscalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuOperationsEscalar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuOperationsEscalar.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuOperationsEscalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuOperationsEscalar.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SubMenuOperationsEscalar.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuOperationsEscalar.Location = new System.Drawing.Point(0, 0);
            this.Btn_SubMenuOperationsEscalar.Name = "Btn_SubMenuOperationsEscalar";
            this.Btn_SubMenuOperationsEscalar.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuOperationsEscalar.TabIndex = 0;
            this.Btn_SubMenuOperationsEscalar.Text = "Escalar vector";
            this.Btn_SubMenuOperationsEscalar.UseVisualStyleBackColor = false;
            this.Btn_SubMenuOperationsEscalar.Click += new System.EventHandler(this.Btn_SubMenuOperationsEscalar_Click);
            // 
            // BtnMenuOperations
            // 
            this.BtnMenuOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.BtnMenuOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenuOperations.FlatAppearance.BorderSize = 0;
            this.BtnMenuOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuOperations.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuOperations.ForeColor = System.Drawing.Color.White;
            this.BtnMenuOperations.Location = new System.Drawing.Point(0, 90);
            this.BtnMenuOperations.Name = "BtnMenuOperations";
            this.BtnMenuOperations.Size = new System.Drawing.Size(283, 40);
            this.BtnMenuOperations.TabIndex = 5;
            this.BtnMenuOperations.Text = "Operaciones";
            this.BtnMenuOperations.UseVisualStyleBackColor = false;
            this.BtnMenuOperations.Visible = false;
            this.BtnMenuOperations.Click += new System.EventHandler(this.BtnMenuOperations_Click);
            // 
            // Panel_SubMenuDibujar
            // 
            this.Panel_SubMenuDibujar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.Panel_SubMenuDibujar.Controls.Add(this.linkLabel_Animar);
            this.Panel_SubMenuDibujar.Controls.Add(this.Btn_DrawVector);
            this.Panel_SubMenuDibujar.Controls.Add(this.txtAxisY);
            this.Panel_SubMenuDibujar.Controls.Add(this.txtAxisX);
            this.Panel_SubMenuDibujar.Controls.Add(this.label2);
            this.Panel_SubMenuDibujar.Controls.Add(this.label1);
            this.Panel_SubMenuDibujar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SubMenuDibujar.Location = new System.Drawing.Point(0, 0);
            this.Panel_SubMenuDibujar.Name = "Panel_SubMenuDibujar";
            this.Panel_SubMenuDibujar.Size = new System.Drawing.Size(283, 90);
            this.Panel_SubMenuDibujar.TabIndex = 4;
            // 
            // linkLabel_Animar
            // 
            this.linkLabel_Animar.AutoSize = true;
            this.linkLabel_Animar.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Animar.LinkColor = System.Drawing.Color.White;
            this.linkLabel_Animar.Location = new System.Drawing.Point(194, 49);
            this.linkLabel_Animar.Name = "linkLabel_Animar";
            this.linkLabel_Animar.Size = new System.Drawing.Size(48, 17);
            this.linkLabel_Animar.TabIndex = 11;
            this.linkLabel_Animar.TabStop = true;
            this.linkLabel_Animar.Text = "Animar";
            this.linkLabel_Animar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Animar_LinkClicked);
            // 
            // Btn_DrawVector
            // 
            this.Btn_DrawVector.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DrawVector.Location = new System.Drawing.Point(173, 13);
            this.Btn_DrawVector.Name = "Btn_DrawVector";
            this.Btn_DrawVector.Size = new System.Drawing.Size(95, 33);
            this.Btn_DrawVector.TabIndex = 9;
            this.Btn_DrawVector.Text = "DIBUJAR";
            this.Btn_DrawVector.UseVisualStyleBackColor = true;
            this.Btn_DrawVector.Click += new System.EventHandler(this.Btn_DrawVector_Click);
            // 
            // txtAxisY
            // 
            this.txtAxisY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtAxisY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAxisY.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.txtAxisY.Location = new System.Drawing.Point(92, 55);
            this.txtAxisY.Name = "txtAxisY";
            this.txtAxisY.Size = new System.Drawing.Size(35, 19);
            this.txtAxisY.TabIndex = 8;
            this.txtAxisY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAxisX
            // 
            this.txtAxisX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtAxisX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAxisX.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAxisX.Location = new System.Drawing.Point(92, 18);
            this.txtAxisX.Name = "txtAxisX";
            this.txtAxisX.Size = new System.Drawing.Size(35, 19);
            this.txtAxisX.TabIndex = 7;
            this.txtAxisX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "x:";
            // 
            // Btn_MenuDibujarOrigen
            // 
            this.Btn_MenuDibujarOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(111)))), ((int)(((byte)(185)))));
            this.Btn_MenuDibujarOrigen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_MenuDibujarOrigen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Btn_MenuDibujarOrigen.FlatAppearance.BorderSize = 0;
            this.Btn_MenuDibujarOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MenuDibujarOrigen.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MenuDibujarOrigen.ForeColor = System.Drawing.Color.White;
            this.Btn_MenuDibujarOrigen.Location = new System.Drawing.Point(0, 0);
            this.Btn_MenuDibujarOrigen.Name = "Btn_MenuDibujarOrigen";
            this.Btn_MenuDibujarOrigen.Size = new System.Drawing.Size(283, 40);
            this.Btn_MenuDibujarOrigen.TabIndex = 0;
            this.Btn_MenuDibujarOrigen.Text = "Vectores";
            this.Btn_MenuDibujarOrigen.UseVisualStyleBackColor = false;
            this.Btn_MenuDibujarOrigen.Click += new System.EventHandler(this.Btn_MenuDibujarOrigen_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(37)))));
            this.PanelTitle.Controls.Add(this.label3);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(300, 100);
            this.PanelTitle.TabIndex = 7;
            // 
            // PanelDetallesGrafico
            // 
            this.PanelDetallesGrafico.Controls.Add(this.label30);
            this.PanelDetallesGrafico.Controls.Add(this.lblAngulo);
            this.PanelDetallesGrafico.Controls.Add(this.label7);
            this.PanelDetallesGrafico.Controls.Add(this.lblCuadrante);
            this.PanelDetallesGrafico.Controls.Add(this.label6);
            this.PanelDetallesGrafico.Controls.Add(this.lblMagnitud);
            this.PanelDetallesGrafico.Controls.Add(this.label4);
            this.PanelDetallesGrafico.Location = new System.Drawing.Point(408, 0);
            this.PanelDetallesGrafico.Name = "PanelDetallesGrafico";
            this.PanelDetallesGrafico.Size = new System.Drawing.Size(464, 62);
            this.PanelDetallesGrafico.TabIndex = 7;
            this.PanelDetallesGrafico.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(129, 5);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(187, 27);
            this.label30.TabIndex = 25;
            this.label30.Text = "Detalles del gráfico";
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngulo.Location = new System.Drawing.Point(409, 32);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(33, 19);
            this.lblAngulo.TabIndex = 24;
            this.lblAngulo.Text = "ang";
            this.lblAngulo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(342, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ángulo: ";
            // 
            // lblCuadrante
            // 
            this.lblCuadrante.AutoSize = true;
            this.lblCuadrante.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuadrante.Location = new System.Drawing.Point(267, 32);
            this.lblCuadrante.Name = "lblCuadrante";
            this.lblCuadrante.Size = new System.Drawing.Size(40, 19);
            this.lblCuadrante.TabIndex = 22;
            this.lblCuadrante.Text = "cuad";
            this.lblCuadrante.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(177, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cuadrante: ";
            // 
            // lblMagnitud
            // 
            this.lblMagnitud.AutoSize = true;
            this.lblMagnitud.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagnitud.Location = new System.Drawing.Point(85, 32);
            this.lblMagnitud.Name = "lblMagnitud";
            this.lblMagnitud.Size = new System.Drawing.Size(37, 19);
            this.lblMagnitud.TabIndex = 20;
            this.lblMagnitud.Text = "mag";
            this.lblMagnitud.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Magnitud: ";
            // 
            // Btn_DrawMap
            // 
            this.Btn_DrawMap.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_DrawMap.Location = new System.Drawing.Point(310, 23);
            this.Btn_DrawMap.Name = "Btn_DrawMap";
            this.Btn_DrawMap.Size = new System.Drawing.Size(20, 25);
            this.Btn_DrawMap.TabIndex = 8;
            this.Btn_DrawMap.Text = "+";
            this.Btn_DrawMap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_DrawMap.UseVisualStyleBackColor = true;
            this.Btn_DrawMap.Click += new System.EventHandler(this.Btn_DrawMap_Click);
            // 
            // Frm_Vector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.Btn_DrawMap);
            this.Controls.Add(this.PanelDetallesGrafico);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.Btn_ReDraw);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "Frm_Vector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de vectores";
            this.Load += new System.EventHandler(this.Frm_Vectores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FreeDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Graph)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.PieMenu.ResumeLayout(false);
            this.PieMenu.PerformLayout();
            this.Panel_SubMenuDibujoLibre.ResumeLayout(false);
            this.Panel_SubMenuDibujoLibre.PerformLayout();
            this.Panel_SubMenuRecta.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.boxEcuacion.ResumeLayout(false);
            this.boxEcuacion.PerformLayout();
            this.Panel_DibujarFiguras.ResumeLayout(false);
            this.Panel_DibujarFiguras.PerformLayout();
            this.Panel_SubMenuDibujarCuadrado.ResumeLayout(false);
            this.Panel_Cuadrado.ResumeLayout(false);
            this.Panel_Cuadrado.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.Panel_CuadradoDibujar.ResumeLayout(false);
            this.Panel_CuadradoDibujar.PerformLayout();
            this.Panel_SubMenuDibujarTriangulo.ResumeLayout(false);
            this.Panel_Triangulo.ResumeLayout(false);
            this.Panel_Triangulo.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.Panel_TrianguloDibujar.ResumeLayout(false);
            this.Panel_TrianguloDibujar.PerformLayout();
            this.Panel_SubMenuDibujarCirculo.ResumeLayout(false);
            this.Panel_DatosCirculo.ResumeLayout(false);
            this.Panel_DatosCirculo.PerformLayout();
            this.Panel_ResultadoCirculo.ResumeLayout(false);
            this.Panel_ResultadoCirculo.PerformLayout();
            this.Panel_MenuDibujarOrigen.ResumeLayout(false);
            this.Panel_MenuDibujarOrigen.PerformLayout();
            this.PanelSubMenuOperations.ResumeLayout(false);
            this.PanelSubMenuOperations.PerformLayout();
            this.PanelSubMenuOperationsProducto.ResumeLayout(false);
            this.PanelProductoVector.ResumeLayout(false);
            this.PanelProductoVector.PerformLayout();
            this.PanelProducto.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.PanelSubMenuOperationsResta.ResumeLayout(false);
            this.PanelRestaVector.ResumeLayout(false);
            this.PanelRestaVector.PerformLayout();
            this.PanelResta.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PanelSubMenuOperationsSuma.ResumeLayout(false);
            this.PanelSumaVector.ResumeLayout(false);
            this.PanelSumaVector.PerformLayout();
            this.PanelSuma.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.PanelSubMenuOperationsSentido.ResumeLayout(false);
            this.PanelSubMenuOperationsSentido.PerformLayout();
            this.PanelSubMenuOperationsEscalar.ResumeLayout(false);
            this.PanelSubMenuOperationsEscalar.PerformLayout();
            this.Panel_SubMenuDibujar.ResumeLayout(false);
            this.Panel_SubMenuDibujar.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.PanelDetallesGrafico.ResumeLayout(false);
            this.PanelDetallesGrafico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctBox_Graph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_ReDraw;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel PanelDetallesGrafico;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCuadrante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMagnitud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Panel_MenuDibujarOrigen;
        private System.Windows.Forms.Panel PanelSubMenuOperations;
        private System.Windows.Forms.Panel PanelSubMenuOperationsProducto;
        private System.Windows.Forms.Panel PanelProductoVector;
        private System.Windows.Forms.Label lblResultadoProducto;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblProductoX2;
        private System.Windows.Forms.Label lblProductoX1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblProductoY2;
        private System.Windows.Forms.Label lblProductoY1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel PanelProducto;
        private System.Windows.Forms.Button BtnCalcularProducto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtVectorProductoY2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtVectorProductoX2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtVectorProductoY1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtVectorProductoX1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button Btn_SubMenuOperationsProducto;
        private System.Windows.Forms.Panel PanelSubMenuOperationsResta;
        private System.Windows.Forms.Panel PanelRestaVector;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblRestaY;
        private System.Windows.Forms.Label lblRestaX;
        private System.Windows.Forms.Button Btn_CalcularResta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel PanelResta;
        private System.Windows.Forms.Button BtnCalcularResta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVectorRestaY2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVectorRestaX2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtVectorRestaY1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtVectorRestaX1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Btn_SubMenuOperationsResta;
        private System.Windows.Forms.Panel PanelSubMenuOperationsSuma;
        private System.Windows.Forms.Panel PanelSumaVector;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblSumaY;
        private System.Windows.Forms.Label lblSumaX;
        private System.Windows.Forms.Button Btn_CalcularSuma;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel PanelSuma;
        private System.Windows.Forms.Button BtnCalcularSuma;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtSumaVectorY2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtSumaVectorX2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtSumaVectorY1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSumaVectorX1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button Btn_SubMenuOperationsSuma;
        private System.Windows.Forms.Panel PanelSubMenuOperationsSentido;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVectorActualY_PnlCambiarSentido;
        private System.Windows.Forms.Button BtnCambiarSentido;
        private System.Windows.Forms.Label lblVectorActualX_PnlCambiarSentido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_SubMenuOperationsSentido;
        private System.Windows.Forms.Panel PanelSubMenuOperationsEscalar;
        private System.Windows.Forms.Label lblVectorActual_PnlEscalar;
        private System.Windows.Forms.Button BtnAplicarEscalar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEscalar;
        private System.Windows.Forms.Button Btn_SubMenuOperationsEscalar;
        private System.Windows.Forms.Button BtnMenuOperations;
        private System.Windows.Forms.Panel Panel_SubMenuDibujar ;
        private System.Windows.Forms.Button Btn_DrawVector;
        private System.Windows.Forms.TextBox txtAxisY;
        private System.Windows.Forms.TextBox txtAxisX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_MenuDibujarOrigen;
        private System.Windows.Forms.Panel Panel_DibujarFiguras;
        private System.Windows.Forms.Button Btn_DibujarFiguras;
        private System.Windows.Forms.LinkLabel linkLabel_Animar;
        private System.Windows.Forms.Button Btn_SubMenuCuadrado;
        private System.Windows.Forms.Panel Panel_SubMenuRecta;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtPendiente;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox txtPuntoY;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox txtPuntoX;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtPuntoBy;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtPuntoBx;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtPuntoAy;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtPuntoAx;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox boxEcuacion;
        private System.Windows.Forms.TextBox txtEcuacionB;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox txtEcuacionY;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox txtEcuacionX;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Button btn_CalcularEcuacionRecta;
        private System.Windows.Forms.PictureBox pictureBox_FreeDraw;
        private System.Windows.Forms.Button Btn_MenuDibujoLibre;
        private System.Windows.Forms.Panel Panel_SubMenuDibujoLibre;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Panel Panel_SubMenuDibujarCuadrado;
        private System.Windows.Forms.Panel Panel_CuadradoDibujar;
        private System.Windows.Forms.Label lblAreaCuadrado;
        private System.Windows.Forms.Label lblPerimetroCuadrado;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label lblAlturaCuadrado;
        private System.Windows.Forms.Label lblBaseCuadrado;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Panel Panel_SubMenuDibujarTriangulo;
        private System.Windows.Forms.Panel Panel_TrianguloDibujar;
        private System.Windows.Forms.Label lblAlturaTriangulo;
        private System.Windows.Forms.Label lblBaseTriangulo;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label lblAreaTriangulo;
        private System.Windows.Forms.Label lblPerimetroTriangulo;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Button Btn_SubMenuTriangulo;
        private System.Windows.Forms.Panel Panel_Triangulo;
        private System.Windows.Forms.Button Btn_DibujarFigurasTriangulo;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox txtTrianguloBy;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox txtTrianguloBx;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox txtTrianguloAy;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox txtTrianguloAx;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Panel Panel_Cuadrado;
        private System.Windows.Forms.Button Btn_DibujarFigurasCuadrado;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtCuadradoPuntoBy;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtCuadradoPuntoBx;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox txtCuadradoPuntoAy;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtCuadradoPuntoAx;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Panel PieMenu;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox txtGeneralX;
        private System.Windows.Forms.TextBox txtGeneralY;
        private System.Windows.Forms.Button Btn_DrawMap;
        private System.Windows.Forms.Button Btn_DibujarEcuaciones;
        private System.Windows.Forms.Button Btn_SubMenuRecta;
        private System.Windows.Forms.Panel Panel_SubMenuDibujarCirculo;
        private System.Windows.Forms.Panel Panel_DatosCirculo;
        private System.Windows.Forms.TextBox txtRadioCirculo;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Button Btn_DibujarCirculo;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Panel Panel_ResultadoCirculo;
        private System.Windows.Forms.Label lblAreaCirculo;
        private System.Windows.Forms.Label lblPerimetroCirculo;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Button Btn_SubMenuCirculo;
    }
}

