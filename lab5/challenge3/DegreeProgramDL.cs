using System.Collections.Generic;

namespace challenge3
{
    public class DegreeProgramDL
    {
        public static List<DegreeProgram> programList = new List<DegreeProgram>();

        public static void addDegreeProgram(DegreeProgram dp)
        {
            programList.Add(dp);
        }
    }
}