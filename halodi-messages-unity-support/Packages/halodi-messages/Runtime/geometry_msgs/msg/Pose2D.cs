using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class Pose2D : Halodi.CDR.DataType<Pose2D>
{

	public Halodi.CDR.TopicDataType<Pose2D> Type => new Pose2DPubSubType();
	
   public double x;
   public double y;
   public double theta;


   public void Set(Pose2D other)
   {
      x = other.x;

      y = other.y;

      theta = other.theta;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Pose2D {");
      builder.Append("x=");
      builder.Append(this.x);      builder.Append(", ");
      builder.Append("y=");
      builder.Append(this.y);      builder.Append(", ");
      builder.Append("theta=");
      builder.Append(this.theta);
      builder.Append("}");
      return builder.ToString();
   }
}


}