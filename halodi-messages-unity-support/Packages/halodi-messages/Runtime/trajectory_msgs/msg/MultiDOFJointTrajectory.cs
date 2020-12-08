using System.Text;
namespace trajectory_msgs.msg
{


/**
       * A representation of a multi-dof joint trajectory (each point is a transformation)
       * Each point along the trajectory will include an array of positions/velocities/accelerations
       * that has the same length as the array of joint names, and has the same order of joints as
       * the joint names array.
       */
[System.Serializable]
public class MultiDOFJointTrajectory : Halodi.CDR.DataType<MultiDOFJointTrajectory>
{

	public Halodi.CDR.TopicDataType<MultiDOFJointTrajectory> Type => new MultiDOFJointTrajectoryPubSubType();
	
   /**
            * The header is used to specify the coordinate frame and the reference time for the trajectory durations
            */
   public std_msgs.msg.Header header;
   public System.Collections.Generic.List<string> joint_names;
   public System.Collections.Generic.List<trajectory_msgs.msg.MultiDOFJointTrajectoryPoint> points;


   public void Set(MultiDOFJointTrajectory other)
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
      	points = new System.Collections.Generic.List<trajectory_msgs.msg.MultiDOFJointTrajectoryPoint>(other.points.Count);
      	for(int i2 = 0; i2 < other.points.Count; i2++)
      	{
      		if(other.points[i2] == null)
      		{
      			points.Add(null);
      		}
      		else
      		{
      			trajectory_msgs.msg.MultiDOFJointTrajectoryPoint newElement = trajectory_msgs.msg.MultiDOFJointTrajectoryPointPubSubType.Create();
      	   		trajectory_msgs.msg.MultiDOFJointTrajectoryPointPubSubType.Copy(other.points[i2], newElement);
      	   		points.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MultiDOFJointTrajectory {");
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