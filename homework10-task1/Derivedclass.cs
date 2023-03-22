using System;
namespace homework10_task1
{
	public class Derivedclass:Fileworker
	{
        
        
            private string fileexpend = "";

            public override string fileexpenditure
            {
                get => fileexpend;
                set => fileexpend = value;
            }

            public override void Delete()
            {

            }
            public override void Edit()
            {

            }

            public override void Read()
            {

            }

            public override void Write()
            {

            }
        
    }
}

