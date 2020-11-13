using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class Vector3 : Halodi.CDR.DataType<Vector3>
{

	public Halodi.CDR.TopicDataType<Vector3> Type => new Vector3PubSubType();
	
   public double x;
   public double y;
   public double z;


   public void Set(Vector3 other)
   {
      x = other.x;

      y = other.y;

      z = other.z;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Vector3 {");
      builder.Append("x=");
      builder.Append(this.x);      builder.Append(", ");
      builder.Append("y=");
      builder.Append(this.y);      builder.Append(", ");
      builder.Append("z=");
      builder.Append(this.z);
      builder.Append("}");
      return builder.ToString();
   }
}


}