using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaAsp.Models;
namespace SistemaAsp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ejercicio1()
        {
            Ejercicios obj = new Ejercicios();
            var c = 0;
            
            obj.resultNum = Convert.ToInt32(Request.Form["num"]);
       for(int i = 1; i < (obj.resultNum + 1); i++){

                if (obj.resultNum % i == 0)
                {
                    c++;

                }

            }
            if (c != 2)
            {
                obj.resultStr = "No es primo";
            }
            else
            {
                obj.resultStr = "Es primo";
            }
      
            return View(obj);
        }

        public ActionResult Ejercicio2()
        {
            Ejercicios obj = new Ejercicios();
            obj.resultStr = Request.Form["num"];
            String palabra , caracter , inverso;
            int i;
            palabra = obj.resultNum.ToString();

            i = palabra.Length;
            inverso = "";
            for (int x=i-1;x>=0;x--)
            {
                caracter = palabra.Substring(x, 1);
                inverso = inverso + caracter;
            }

            if (palabra == inverso)
            {
                obj.resultStr = "Es palindromo";
            }
            else
            {
                obj.resultStr = "No es palindromo";
            }

           
            return View(obj);
        }

        public ActionResult Ejercicio3()
        {
      
            //Ejercicios obj = new Ejercicios();
            //int[] datos=new int[5];
            return View();
        }
        public ActionResult Ejercicio4()
        {

            return View();
        }
        public ActionResult Ejercicio5()
        {
            Ejercicios obj = new Ejercicios();
            obj.resultStr = Request.Form["num"];
            String palabra , palabralista;
           
            palabra = obj.resultNum.ToString();

            char[] cadena = palabra.ToCharArray();

            Array.Reverse(cadena);

            palabralista = cadena.ToString();

            obj.resultStr = palabralista;

            return View(obj);
        }
    }
}