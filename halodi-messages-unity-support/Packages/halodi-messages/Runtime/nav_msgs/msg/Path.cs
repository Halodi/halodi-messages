using System.Text;
namespace nav_msgs.msg
{


/**
       * An array of poses that represents a Path for a robot to follow.
       */
[System.Serializable]
public class Path
{
   public std_msgs.msg.Header header;
   public System.Collections.Generic.List<geometry_msgs.msg.PoseStamped> poses;


   public void Set(Path other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);


      if(other.poses == null)
      {
      	poses = null;
      }
      else
      {
      	poses = new System.Collections.Generic.List<geometry_msgs.msg.PoseStamped>(other.poses.Count);
      	for(int i1 = 0; i1 < other.poses.Count; i1++)
      	{
      		if(other.poses[i1] == null)
      		{
      			poses.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.PoseStamped newElement = geometry_msgs.msg.PoseStampedPubSubType.Create();
      	   		geometry_msgs.msg.PoseStampedPubSubType.Copy(other.poses[i1], newElement);
      	   		poses.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Path {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("poses=");
      builder.Append(this.poses);
      builder.Append("}");
      return builder.ToString();
   }
}


}