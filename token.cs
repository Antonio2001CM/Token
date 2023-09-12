using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Escuela
{
    public class Token
    {
        public enum Tipos
        {
            Identificador,Numero,Caracter,Asignacion,FinSentencia,
            OperadorRelacional, OperadorLogico, OperadorTermino, OperadorFactor,
            IncrementoTermino, IncrementoFactor,
            Inicio, Fin
        }
        private string contenido;
        private Tipos  clasificacion;
        public Token()
        {
            contenido = "";
            clasificacion = Tipos.Identificador;
        }
        public void setContenido(string contenido)
        {
            this.contenido = contenido;
        }
        public void setClasificacion(Tipos clasificacion)
        {
            this.clasificacion = clasificacion;
        }
        public string getContenido()
        {
            return this.contenido;
        }
        public Tipos getClasificacion()
        {
            return this.clasificacion;
        }
    }
}