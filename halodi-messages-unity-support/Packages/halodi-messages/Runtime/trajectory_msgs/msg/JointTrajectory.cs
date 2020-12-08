using System.Text;
namespace trajectory_msgs.msg
{


[System.Serializable]
public class JointTrajectory : Halodi.CDR.DataType<JointTrajectory>
{

	public Halodi.CDR.TopicDataType<JointTrajectory> Type => new JointTrajectoryPubSubType();
	
   public std_msgs.msg.Header header;
   public System.Collections.Generic.List<string> joint_names;
   public System.Collections.Generic.List<trajectory_msgs.msg.JointTrajectoryPoint> points;


   public void Set(JointTrajectory other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);


      if(other.joint_names == null)
      {
      	joint_names = null;
      }
      else
      {
      	joint_names = new System.Collections.Generic.List<string>(other.joint_names.Count);
      	for(int i1 = 0; i1 < other.joint_names.Count; i1++)
      	{
         		joint_names.Add(other.joint_names[i1]);
      	}
      }

      if(other.points == null)
      {
      	points = null;
      }
      else
      {
      	points = new System.Collections.Generic.List<trajectory_msgs.msg.JointTrajectoryPoint>(other.points.Count);
      	for(int i2 = 0; i2 < other.points.Count; i2++)
      	{
      		if(other.points[i2] == null)
      		{
      			points.Add(null);
      		}
      		else
      		{
      			trajectory_msgs.msg.JointTrajectoryPoint newElement = trajectory_msgs.msg.JointTrajectoryPointPubSubType.Create();
      	   		trajectory_msgs.msg.JointTrajectoryPointPubSubType.Copy(other.points[i2], newElement);
      	   		points.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JointTrajectory {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("joint_names=");
      builder.Append(this.joint_names);      builder.Append(", ");
      builder.Append("points=");
      builder.Append(this.points);
      builder.Append("}");
      return builder.ToString();
   }
}


}