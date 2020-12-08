using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class Point32 : Halodi.CDR.DataType<Point32>
{

	public Halodi.CDR.TopicDataType<Point32> Type => new Point32PubSubType();
	
   public float x;
   public float y;
   public float z;


   public void Set(Point32 other)
   {
      x = other.x;

      y = other.y;

      z = other.z;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Point32 {");
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