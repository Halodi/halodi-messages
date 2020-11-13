using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class Pose : Halodi.CDR.DataType<Pose>
{

	public Halodi.CDR.TopicDataType<Pose> Type => new PosePubSubType();
	
   public geometry_msgs.msg.Point position;
   public geometry_msgs.msg.Quaternion orientation;


   public void Set(Pose other)
   {
      geometry_msgs.msg.PointPubSubType.Copy(other.position, position);

      geometry_msgs.msg.QuaternionPubSubType.Copy(other.orientation, orientation);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Pose {");
      builder.Append("position=");
      builder.Append(this.position);      builder.Append(", ");
      builder.Append("orientation=");
      builder.Append(this.orientation);
      builder.Append("}");
      return builder.ToString();
   }
}


}