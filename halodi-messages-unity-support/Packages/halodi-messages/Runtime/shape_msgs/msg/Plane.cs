using System.Text;
namespace shape_msgs.msg
{


[System.Serializable]
public class Plane : Halodi.CDR.DataType<Plane>
{

	public Halodi.CDR.TopicDataType<Plane> Type => new PlanePubSubType();
	
   /**
            * Representation of a plane, using the plane equation ax + by + cz + d = 0.
            * 
            * a := coef[0]
            * b := coef[1]
            * c := coef[2]
            * d := coef[3]
            */
   public double[] coef = new double[4];


   public void Set(Plane other)
   {
      for(int i1 = 0; i1 < 4; ++i1)
      {
            coef[i1] = other.coef[i1];

      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Plane {");
      builder.Append("coef=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.coef));
      builder.Append("}");
      return builder.ToString();
   }
}


}