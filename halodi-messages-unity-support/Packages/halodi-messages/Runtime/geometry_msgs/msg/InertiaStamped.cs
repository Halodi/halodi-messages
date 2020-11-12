using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class InertiaStamped
{
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.Inertia inertia;


   public void Set(InertiaStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.InertiaPubSubType.Copy(other.inertia, inertia);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("InertiaStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("inertia=");
      builder.Append(this.inertia);
      builder.Append("}");
      return builder.ToString();
   }
}


}