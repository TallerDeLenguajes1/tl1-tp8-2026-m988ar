namespace Tareas
{
    public class Tarea
    {
        private int tareaID;

        private string descripcion;

        private int duracion;

        private int realizada;

        public int TareaID { get => tareaID; set => tareaID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public int Duracion
        {
            get => duracion;
            set  {if(value>=10 && value <=100){duracion = value;}}
        }

        public int Realizada { get => realizada; set => realizada = value;}

        public Tarea()
        {
            tareaID = 0;
            descripcion = "@";
            duracion = 0;
            Realizada = 0;
        }
    }
}