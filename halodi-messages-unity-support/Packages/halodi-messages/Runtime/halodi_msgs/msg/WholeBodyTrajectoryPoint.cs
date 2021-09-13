using System.Text;
namespace halodi_msgs.msg
{


/**
          * Taskspace trajectory point
          *
          * 
          */
[System.Serializable]
public class WholeBodyTrajectoryPoint : Halodi.CDR.DataType<WholeBodyTrajectoryPoint>
{

	public Halodi.CDR.TopicDataType<WholeBodyTrajectoryPoint> Type => new WholeBodyTrajectoryPointPubSubType();
	
   /**
                 * Execution time for the trajectory, relative to the start time.
                 *
                 */
   public builtin_interfaces.msg.Duration time_from_start;
   public System.Collections.Generic.List<halodi_msgs.msg.TaskSpaceCommand> task_space_commands;
   public System.Collections.Generic.List<halodi_msgs.msg.JointSpaceCommand> joint_space_commands;
   /**
                 * Contact point state to apply at time_from_start
                 *
                 */
   public System.Collections.Generic.List<halodi_msgs.msg.ContactPointCommand> contact_point_commands;
   public System.Collections.Generic.List<geometry_msgs.msg.Vector3> icp_offset_command;
   /**
                 * Optional left hand command
                 * 
                 * Gets send to the hand topic at the start of the point execution
                 *
                 */
   public System.Collections.Generic.List<halodi_msgs.msg.HandCommand> left_hand_command;
   /**
                 * Optional right hand command
                 * 
                 * Gets send to the hand topic at the start of the point execution
                 *
                 */
   public System.Collections.Generic.List<halodi_msgs.msg.HandCommand> right_hand_command;


   public void Set(WholeBodyTrajectoryPoint other)
   {
      builtin_interfaces.msg.DurationPubSubType.Copy(other.time_from_start, time_from_start);


      if(other.task_space_commands == null)
      {
      	task_space_commands = null;
      }
      else
      {
      	task_space_commands = new System.Collections.Generic.List<halodi_msgs.msg.TaskSpaceCommand>(other.task_space_commands.Count);
      	for(int i1 = 0; i1 < other.task_space_commands.Count; i1++)
      	{
      		if(other.task_space_commands[i1] == null)
      		{
      			task_space_commands.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.TaskSpaceCommand newElement = halodi_msgs.msg.TaskSpaceCommandPubSubType.Create();
      	   		halodi_msgs.msg.TaskSpaceCommandPubSubType.Copy(other.task_space_commands[i1], newElement);
      	   		task_space_commands.Add(newElement);
      		}	}
      }

      if(other.joint_space_commands == null)
      {
      	joint_space_commands = null;
      }
      else
      {
      	joint_space_commands = new System.Collections.Generic.List<halodi_msgs.msg.JointSpaceCommand>(other.joint_space_commands.Count);
      	for(int i2 = 0; i2 < other.joint_space_commands.Count; i2++)
      	{
      		if(other.joint_space_commands[i2] == null)
      		{
      			joint_space_commands.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.JointSpaceCommand newElement = halodi_msgs.msg.JointSpaceCommandPubSubType.Create();
      	   		halodi_msgs.msg.JointSpaceCommandPubSubType.Copy(other.joint_space_commands[i2], newElement);
      	   		joint_space_commands.Add(newElement);
      		}	}
      }

      if(other.contact_point_commands == null)
      {
      	contact_point_commands = null;
      }
      else
      {
      	contact_point_commands = new System.Collections.Generic.List<halodi_msgs.msg.ContactPointCommand>(other.contact_point_commands.Count);
      	for(int i3 = 0; i3 < other.contact_point_commands.Count; i3++)
      	{
      		if(other.contact_point_commands[i3] == null)
      		{
      			contact_point_commands.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.ContactPointCommand newElement = halodi_msgs.msg.ContactPointCommandPubSubType.Create();
      	   		halodi_msgs.msg.ContactPointCommandPubSubType.Copy(other.contact_point_commands[i3], newElement);
      	   		contact_point_commands.Add(newElement);
      		}	}
      }

      if(other.icp_offset_command == null)
      {
      	icp_offset_command = null;
      }
      else
      {
      	icp_offset_command = new System.Collections.Generic.List<geometry_msgs.msg.Vector3>(other.icp_offset_command.Count);
      	for(int i4 = 0; i4 < other.icp_offset_command.Count; i4++)
      	{
      		if(other.icp_offset_command[i4] == null)
      		{
      			icp_offset_command.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Vector3 newElement = geometry_msgs.msg.Vector3PubSubType.Create();
      	   		geometry_msgs.msg.Vector3PubSubType.Copy(other.icp_offset_command[i4], newElement);
      	   		icp_offset_command.Add(newElement);
      		}	}
      }

      if(other.left_hand_command == null)
      {
      	left_hand_command = null;
      }
      else
      {
      	left_hand_command = new System.Collections.Generic.List<halodi_msgs.msg.HandCommand>(other.left_hand_command.Count);
      	for(int i5 = 0; i5 < other.left_hand_command.Count; i5++)
      	{
      		if(other.left_hand_command[i5] == null)
      		{
      			left_hand_command.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.HandCommand newElement = halodi_msgs.msg.HandCommandPubSubType.Create();
      	   		halodi_msgs.msg.HandCommandPubSubType.Copy(other.left_hand_command[i5], newElement);
      	   		left_hand_command.Add(newElement);
      		}	}
      }

      if(other.right_hand_command == null)
      {
      	right_hand_command = null;
      }
      else
      {
      	right_hand_command = new System.Collections.Generic.List<halodi_msgs.msg.HandCommand>(other.right_hand_command.Count);
      	for(int i6 = 0; i6 < other.right_hand_command.Count; i6++)
      	{
      		if(other.right_hand_command[i6] == null)
      		{
      			right_hand_command.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.HandCommand newElement = halodi_msgs.msg.HandCommandPubSubType.Create();
      	   		halodi_msgs.msg.HandCommandPubSubType.Copy(other.right_hand_command[i6], newElement);
      	   		right_hand_command.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("WholeBodyTrajectoryPoint {");
      builder.Append("time_from_start=");
      builder.Append(this.time_from_start);      builder.Append(", ");
      builder.Append("task_space_commands=");
      builder.Append(this.task_space_commands);      builder.Append(", ");
      builder.Append("joint_space_commands=");
      builder.Append(this.joint_space_commands);      builder.Append(", ");
      builder.Append("contact_point_commands=");
      builder.Append(this.contact_point_commands);      builder.Append(", ");
      builder.Append("icp_offset_command=");
      builder.Append(this.icp_offset_command);      builder.Append(", ");
      builder.Append("left_hand_command=");
      builder.Append(this.left_hand_command);      builder.Append(", ");
      builder.Append("right_hand_command=");
      builder.Append(this.right_hand_command);
      builder.Append("}");
      return builder.ToString();
   }
}


}