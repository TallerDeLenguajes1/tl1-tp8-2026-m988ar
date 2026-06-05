namespace Tareas
{
    public class Tarea
    {
        private int tareaID;

        private string descripcion;

        private int duracion;

        private bool realizada;

        public int TareaID { get => tareaID; set => tareaID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public int Duracion
        {
            get => duracion;
            set  {if(value>=10 && value <=100){duracion = value;}}
        }

        public bool Realizada { get => realizada; set => realizada = value;}
    }
}