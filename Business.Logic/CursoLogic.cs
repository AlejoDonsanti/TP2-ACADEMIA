﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic : BusinessLogic
    {
        public CursoAdapter cursoAdapter;

        public CursoLogic()
        {
            cursoAdapter = new CursoAdapter();
        }
        public List<Curso> GetAll()
        {
            try
            {
                List<Curso> cursos = cursoAdapter.GetAll();
                return cursos;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de Cursos", Ex);
                throw ExcepcionManejada;
            }
        }
        public Curso GetOne(int ID)
        {
            Curso curso = cursoAdapter.GetOne(ID);
            return curso;
        }
        public void Delete(int ID)
        {
            cursoAdapter.Delete(ID);
        }
        public void Save(Curso curso)
        {
            cursoAdapter.Save(curso);
        }
    }
}
