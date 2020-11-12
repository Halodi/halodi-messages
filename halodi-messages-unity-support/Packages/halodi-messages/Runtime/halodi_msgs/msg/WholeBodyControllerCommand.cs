using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class WholeBodyControllerCommand
{
   public int sequence_id;
   public halodi_msgs.msg.BalanceMode balance_mode;
   /**
                   * Task space commands
                   *
                   * One or more tasks space commands. 
                   * 
                   * - If more than one task space is sent for the same body_frame, they are both ignored.
                   * - If joint space commands are provided for the kinematic chain for a task space command, the joint space commands get ignored
                   * - If no task space or joint space command is provided, the robot will hold position
                   * - If no new settings are provided, the controller will hold position and set the desired velocity and acceleration to zero
                   */
   public System.Collections.Generic.List<halodi_msgs.msg.TaskSpaceCommand> task_space_commands;
   /**
                   * Joint space commands
                   *
                   * One or more commanded joint angles
                   *
                   * - If no task space command is sent for the kinematic chain the joint is in, the controller for that kinematic chain switches to joint space control. 
                   * - Joints not set in a kinematic chain are frozen at the current position with default gains.
                   * - If more than one joint space command is sent for the same joint, they are both ignored. 
                   * - If a task space command is set for the kinematic chain a joint is in, the joint space command gets ignored.
                   *
                   */
   public System.Collections.Generic.List<halodi_msgs.msg.JointSpaceCommand> joint_space_commands;
   /**
                    * Contact point commands
                    * 
                    * One or more commands for setting contact points.
                    * 
                    * - Only valid when balance mode is DISABLED
                    * - If no contact point command is provided, the controller will use the previous contact point command (or default)
                    * - If more than one contact point command is sent for the same contact point, the behaviour is undefined.
                    *
                    */
   public System.Collections.Generic.List<halodi_msgs.msg.ContactPointCommand> contact_point_commands;
   /**
                     * Sequence of driving commands into the future
                     * 
                     * If not set, the robot will continue driving till "timeout", after which it stops
                     * 
                     * "timeout" is currently set to approximatly 100ms
                     * 
                     * Currently, only the first driving command is used. This functionality is available to allow future prediciton in the MPC.
                     *
                     */
   public System.Collections.Generic.List<halodi_msgs.msg.DrivingCommand> driving_command;
   /**
                     *
                     * Sequence of ICP position offests into the future
                     *
                     * If not set, the robot will hold the current icp offset.
                     *
                     * Currently, only the first icp position offset is used. This functionality is available to allow future prediciton in the MPC.
                     *
                     */
   public System.Collections.Generic.List<geometry_msgs.msg.Vector3> icp_command;


   public void Set(WholeBodyControllerCommand other)
   {
      sequence_id = other.sequence_id;

      halodi_msgs.msg.BalanceModePubSubType.Copy(other.balance_mode, balance_mode);


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

      if(other.driving_command == null)
      {
      	driving_command = null;
      }
      else
      {
      	driving_command = new System.Collections.Generic.List<halodi_msgs.msg.DrivingCommand>(other.driving_command.Count);
      	for(int i4 = 0; i4 < other.driving_command.Count; i4++)
      	{
      		if(other.driving_command[i4] == null)
      		{
      			driving_command.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.DrivingCommand newElement = halodi_msgs.msg.DrivingCommandPubSubType.Create();
      	   		halodi_msgs.msg.DrivingCommandPubSubType.Copy(other.driving_command[i4], newElement);
      	   		driving_command.Add(newElement);
      		}	}
      }

      if(other.icp_command == null)
      {
      	icp_command = null;
      }
      else
      {
      	icp_command = new System.Collections.Generic.List<geometry_msgs.msg.Vector3>(other.icp_command.Count);
      	for(int i5 = 0; i5 < other.icp_command.Count; i5++)
      	{
      		if(other.icp_command[i5] == null)
      		{
      			icp_command.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Vector3 newElement = geometry_msgs.msg.Vector3PubSubType.Create();
      	   		geometry_msgs.msg.Vector3PubSubType.Copy(other.icp_command[i5], newElement);
      	   		icp_command.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("WholeBodyControllerCommand {");
      builder.Append("sequence_id=");
      builder.Append(this.sequence_id);      builder.Append(", ");
      builder.Append("balance_mode=");
      builder.Append(this.balance_mode);      builder.Append(", ");
      builder.Append("task_space_commands=");
      builder.Append(this.task_space_commands);      builder.Append(", ");
      builder.Append("joint_space_commands=");
      builder.Append(this.joint_space_commands);      builder.Append(", ");
      builder.Append("contact_point_commands=");
      builder.Append(this.contact_point_commands);      builder.Append(", ");
      builder.Append("driving_command=");
      builder.Append(this.driving_command);      builder.Append(", ");
      builder.Append("icp_command=");
      builder.Append(this.icp_command);
      builder.Append("}");
      return builder.ToString();
   }
}


}