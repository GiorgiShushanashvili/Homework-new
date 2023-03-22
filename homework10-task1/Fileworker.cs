using System;
namespace homework10_task1
{
	public abstract class Fileworker
	{
        public int filemax { get; set; }
        public abstract string fileexpenditure { get; set; }


        public abstract void Read();

        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();

    }
}

