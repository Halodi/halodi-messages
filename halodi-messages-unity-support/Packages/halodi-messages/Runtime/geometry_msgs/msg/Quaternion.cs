using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class Quaternion
{
   public double x;
   public double y;
   public double z;
   public double w;


   public void Set(Quaternion other)
   {
      x = other.x;

      y = other.y;

      z = other.z;

      w = other.w;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Quaternion {");
      builder.Append("x=");
      builder.Append(this.x);      builder.Append(", ");
      builder.Append("y=");
      builder.Append(this.y);      builder.Append(", ");
      builder.Append("z=");
      builder.Append(this.z);      builder.Append(", ");
      builder.Append("w=");
      builder.Append(this.w);
      builder.Append("}");
      return builder.ToString();
   }
}


}