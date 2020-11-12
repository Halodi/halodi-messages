using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class Point
{
   public double x;
   public double y;
   public double z;


   public void Set(Point other)
   {
      x = other.x;

      y = other.y;

      z = other.z;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Point {");
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