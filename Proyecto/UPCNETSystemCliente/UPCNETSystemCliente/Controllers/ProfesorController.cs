using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPCNETSystemCliente.ViewModel.Profesor;

namespace UPCNETSystemCliente.Controllers
{
    public class ProfesorController : Controller
    {
        public ActionResult Profesor()
        {
            return RedirectToAction("Horario");
        }

        public ActionResult Horario() 
        {
            HorarioViewModel objViewModel = new HorarioViewModel();
            string id = Session["IDProfesor"].ToString();
            objViewModel.Fill(id);
            return View(objViewModel);
        }

        public ActionResult LstCurso()
        {
            LstCursoViewModel objViewModel = new LstCursoViewModel();
            objViewModel.Fill(Session["IDProfesor"].ToString());
            return View(objViewModel);
        }

        public ActionResult LstAlumno(string idCurso)
        {
            LstAlumnoViewModel objViewModel = new LstAlumnoViewModel();
            objViewModel.Fill(idCurso);
            return View(objViewModel);
        }
    }
}
