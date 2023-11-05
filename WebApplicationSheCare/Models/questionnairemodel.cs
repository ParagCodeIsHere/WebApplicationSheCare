using System.ComponentModel.DataAnnotations;

namespace WebApplicationSheCare.Models
{
    public class questionnairemodel
    {
        [Key]
        public int UserId { get; set; }
        public Boolean HaveHeadache{ get; set; }
        //public List<CrampRelieveTaken> TakesCrampRelieve { get; set; }
        public Boolean RelieveByMeds { get; set; }
        public Boolean RelieveByHerbs { get; set; }
        public Boolean RelieveHeatingPod { get; set; }
        public Boolean HaveBloating { get; set; }
        public Boolean HaveMoodSwing{ get; set; }
        public Boolean HaveFatigue{ get; set; }
        public Boolean HeavyFlow { get; set; }
        public Boolean IrregularCycle { get; set; }
        public Boolean Itches { get; set; }
        public Boolean IsBadCramps { get; set; }
        public Boolean LegPain { get; set; }
        public Boolean LightFlow { get; set; }
        public Boolean ModerateFlow { get; set; }
        public Boolean ProblemInDigetion { get; set; }
        //public List<SleepCycle> SleepCycles { get; set; }
        public Boolean SleepWell { get; set; }
        public Boolean Insomia { get; set; }
        public Boolean Diffuclulty { get; set; }
        public Boolean Vomiting{ get; set; }
    }
    //public class SleepCycle
    //{
        
    //}

    //public class CrampRelieveTaken
    //{
    //    //stads out for pods bottels and patch
    //}
}
