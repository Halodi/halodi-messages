using System.Text;
namespace sensor_msgs.msg
{


/**
       * Representation of state for joints with multiple degrees of freedom,
       * following the structure of JointState.
       * 
       * It is assumed that a joint in a system corresponds to a transform that gets applied
       * along the kinematic chain. For example, a planar joint (as in URDF) is 3DOF (x, y, yaw)
       * and those 3DOF can be expressed as a transformation matrix, and that transformation
       * matrix can be converted back to (x, y, yaw)
       * 
       * Each joint is uniquely identified by its name
       * The header specifies the time at which the joint states were recorded. All the joint states
       * in one message have to be recorded at the same time.
       * 
       * This message consists of a multiple arrays, one for each part of the joint state.
       * The goal is to make each of the fields optional. When e.g. your joints have no
       * wrench associated with them, you can leave the wrench array empty.
       * 
       * All arrays in this message should have the same size, or be empty.
       * This is the only way to uniquely associate the joint name with the correct
       * states.
       */
[System.Serializable]
public class MultiDOFJointState
{
   public std_msgs.msg.Header header;
   public System.Collections.Generic.List<string> joint_names;
   public System.Collections.Generic.List<geometry_msgs.msg.Transform> transforms;
   public System.Collections.Generic.List<geometry_msgs.msg.Twist> twist;
   public System.Collections.Generic.List<geometry_msgs.msg.Wrench> wrench;


   public void Set(MultiDOFJointState other)
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

      if(other.transforms == null)
      {
      	transforms = null;
      }
      else
      {
      	transforms = new System.Collections.Generic.List<geometry_msgs.msg.Transform>(other.transforms.Count);
      	for(int i2 = 0; i2 < other.transforms.Count; i2++)
      	{
      		if(other.transforms[i2] == null)
      		{
      			transforms.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Transform newElement = geometry_msgs.msg.TransformPubSubType.Create();
      	   		geometry_msgs.msg.TransformPubSubType.Copy(other.transforms[i2], newElement);
      	   		transforms.Add(newElement);
      		}	}
      }

      if(other.twist == null)
      {
      	twist = null;
      }
      else
      {
      	twist = new System.Collections.Generic.List<geometry_msgs.msg.Twist>(other.twist.Count);
      	for(int i3 = 0; i3 < other.twist.Count; i3++)
      	{
      		if(other.twist[i3] == null)
      		{
      			twist.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Twist newElement = geometry_msgs.msg.TwistPubSubType.Create();
      	   		geometry_msgs.msg.TwistPubSubType.Copy(other.twist[i3], newElement);
      	   		twist.Add(newElement);
      		}	}
      }

      if(other.wrench == null)
      {
      	wrench = null;
      }
      else
      {
      	wrench = new System.Collections.Generic.List<geometry_msgs.msg.Wrench>(other.wrench.Count);
      	for(int i4 = 0; i4 < other.wrench.Count; i4++)
      	{
      		if(other.wrench[i4] == null)
      		{
      			wrench.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Wrench newElement = geometry_msgs.msg.WrenchPubSubType.Create();
      	   		geometry_msgs.msg.WrenchPubSubType.Copy(other.wrench[i4], newElement);
      	   		wrench.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MultiDOFJointState {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("joint_names=");
      builder.Append(this.joint_names);      builder.Append(", ");
      builder.Append("transforms=");
      builder.Append(this.transforms);      builder.Append(", ");
      builder.Append("twist=");
      builder.Append(this.twist);      builder.Append(", ");
      builder.Append("wrench=");
      builder.Append(this.wrench);
      builder.Append("}");
      return builder.ToString();
   }
}


}