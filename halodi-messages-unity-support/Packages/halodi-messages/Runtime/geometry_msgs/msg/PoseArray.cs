using System.Text;
namespace geometry_msgs.msg
{


/**
       * An array of poses with a header for global reference.
       */
[System.Serializable]
public class PoseArray
{
   public std_msgs.msg.Header header;
   public System.Collections.Generic.List<geometry_msgs.msg.Pose> poses;


   public void Set(PoseArray other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);


      if(other.poses == null)
      {
      	poses = null;
      }
      else
      {
      	poses = new System.Collections.Generic.List<geometry_msgs.msg.Pose>(other.poses.Count);
      	for(int i1 = 0; i1 < other.poses.Count; i1++)
      	{
      		if(other.poses[i1] == null)
      		{
      			poses.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Pose newElement = geometry_msgs.msg.PosePubSubType.Create();
      	   		geometry_msgs.msg.PosePubSubType.Copy(other.poses[i1], newElement);
      	   		poses.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("PoseArray {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("poses=");
      builder.Append(this.poses);
      builder.Append("}");
      return builder.ToString();
   }
}


}