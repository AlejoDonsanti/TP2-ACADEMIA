﻿using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Materias : ApplicationForm
    {
        public Materias()
        {
            InitializeComponent();
        }

        public void Listar() 
        {
            MateriaLogic ml = new MateriaLogic();
            PlanLogic pl = new PlanLogic();
            try
            {
                List<Materia> materias = ml.GetAll();
                List<Plan> planes = pl.GetAll();

                var query =
                        from m in materias
                        join p in planes
                        on m.IDPlan equals p.ID
                        select new
                        {
                            ID = m.ID,
                            Descripcion = m.Descripcion,
                            Hs_Semanales = m.HSSemanales,
                            Hs_Totales = m.HSTotales,
                            Plan = p.Descripcion
                        };
                dgvMateria.DataSource = query.ToList();

            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de Materias", Ex);
                MessageBox.Show("Error al recuperar lista de Materias", "Materia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ExcepcionManejada;
            }
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}