using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class Transform : Halodi.CDR.DataType<Transform>
{

	public Halodi.CDR.TopicDataType<Transform> Type => new TransformPubSubType();
	
   public geometry_msgs.msg.Vector3 translation;
   public geometry_msgs.msg.Quaternion rotation;


   public void Set(Transform other)
   {
      geometry_msgs.msg.Vector3PubSubType.Copy(other.translation, translation);

      geometry_msgs.msg.QuaternionPubSubType.Copy(other.rotation, rotation);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Transform {");
      builder.Append("translation=");
      builder.Append(this.translation);      builder.Append(", ");
      builder.Append("rotation=");
      builder.Append(this.rotation);
      builder.Append("}");
      return builder.ToString();
   }
}


}