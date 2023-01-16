using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "WholeBodyControllerCommand" defined in "WholeBodyControllerCommand.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from WholeBodyControllerCommand.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit WholeBodyControllerCommand.idl instead.
*
*/
public class WholeBodyControllerCommandPubSubType : Halodi.CDR.TopicDataType<WholeBodyControllerCommand>
{
   public override string Name => "halodi_msgs::msg::dds_::WholeBodyControllerCommand_";


   public static int getCdrSerializedSize(halodi_msgs.msg.WholeBodyControllerCommand data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.WholeBodyControllerCommand data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += halodi_msgs.msg.BalanceModePubSubType.getCdrSerializedSize(data.balance_mode, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.task_space_commands.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.TaskSpaceCommandPubSubType.getCdrSerializedSize(data.task_space_commands[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.joint_space_commands.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.JointSpaceCommandPubSubType.getCdrSerializedSize(data.joint_space_commands[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.contact_point_commands.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.ContactPointCommandPubSubType.getCdrSerializedSize(data.contact_point_commands[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.driving_command.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.DrivingCommandPubSubType.getCdrSerializedSize(data.driving_command[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.icp_command.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.icp_command[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.WholeBodyControllerCommand data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.sequence_id);

      halodi_msgs.msg.BalanceModePubSubType.write(data.balance_mode, cdr);

      	if(data.task_space_commands == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int task_space_commands_length = data.task_space_commands.Count;
            cdr.write_type_2(task_space_commands_length);
            for (int i0 = 0; i0 < task_space_commands_length; i0++)
            {
      			halodi_msgs.msg.TaskSpaceCommandPubSubType.write(data.task_space_commands[i0], cdr);	      }
        }
      	if(data.joint_space_commands == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int joint_space_commands_length = data.joint_space_commands.Count;
            cdr.write_type_2(joint_space_commands_length);
            for (int i0 = 0; i0 < joint_space_commands_length; i0++)
            {
      			halodi_msgs.msg.JointSpaceCommandPubSubType.write(data.joint_space_commands[i0], cdr);	      }
        }
      	if(data.contact_point_commands == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int contact_point_commands_length = data.contact_point_commands.Count;
            cdr.write_type_2(contact_point_commands_length);
            for (int i0 = 0; i0 < contact_point_commands_length; i0++)
            {
      			halodi_msgs.msg.ContactPointCommandPubSubType.write(data.contact_point_commands[i0], cdr);	      }
        }
      	if(data.driving_command == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int driving_command_length = data.driving_command.Count;
            cdr.write_type_2(driving_command_length);
            for (int i0 = 0; i0 < driving_command_length; i0++)
            {
      			halodi_msgs.msg.DrivingCommandPubSubType.write(data.driving_command[i0], cdr);	      }
        }
      	if(data.icp_command == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int icp_command_length = data.icp_command.Count;
            cdr.write_type_2(icp_command_length);
            for (int i0 = 0; i0 < icp_command_length; i0++)
            {
      			geometry_msgs.msg.Vector3PubSubType.write(data.icp_command[i0], cdr);	      }
        }
   }

   public static void read(halodi_msgs.msg.WholeBodyControllerCommand data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.sequence_id=cdr.read_type_2();
      	
      data.balance_mode = halodi_msgs.msg.BalanceModePubSubType.Create();
      halodi_msgs.msg.BalanceModePubSubType.read(data.balance_mode, cdr);
      	

      int task_space_commands_length = cdr.read_type_2();
      data.task_space_commands = new System.Collections.Generic.List<halodi_msgs.msg.TaskSpaceCommand>(task_space_commands_length);
      for(int i = 0; i < task_space_commands_length; i++)
      {
      	halodi_msgs.msg.TaskSpaceCommand new_task_space_commands = halodi_msgs.msg.TaskSpaceCommandPubSubType.Create(); 
      	halodi_msgs.msg.TaskSpaceCommandPubSubType.read(new_task_space_commands, cdr);
      	data.task_space_commands.Add(new_task_space_commands);	
      	
      }

      	

      int joint_space_commands_length = cdr.read_type_2();
      data.joint_space_commands = new System.Collections.Generic.List<halodi_msgs.msg.JointSpaceCommand>(joint_space_commands_length);
      for(int i = 0; i < joint_space_commands_length; i++)
      {
      	halodi_msgs.msg.JointSpaceCommand new_joint_space_commands = halodi_msgs.msg.JointSpaceCommandPubSubType.Create(); 
      	halodi_msgs.msg.JointSpaceCommandPubSubType.read(new_joint_space_commands, cdr);
      	data.joint_space_commands.Add(new_joint_space_commands);	
      	
      }

      	

      int contact_point_commands_length = cdr.read_type_2();
      data.contact_point_commands = new System.Collections.Generic.List<halodi_msgs.msg.ContactPointCommand>(contact_point_commands_length);
      for(int i = 0; i < contact_point_commands_length; i++)
      {
      	halodi_msgs.msg.ContactPointCommand new_contact_point_commands = halodi_msgs.msg.ContactPointCommandPubSubType.Create(); 
      	halodi_msgs.msg.ContactPointCommandPubSubType.read(new_contact_point_commands, cdr);
      	data.contact_point_commands.Add(new_contact_point_commands);	
      	
      }

      	

      int driving_command_length = cdr.read_type_2();
      data.driving_command = new System.Collections.Generic.List<halodi_msgs.msg.DrivingCommand>(driving_command_length);
      for(int i = 0; i < driving_command_length; i++)
      {
      	halodi_msgs.msg.DrivingCommand new_driving_command = halodi_msgs.msg.DrivingCommandPubSubType.Create(); 
      	halodi_msgs.msg.DrivingCommandPubSubType.read(new_driving_command, cdr);
      	data.driving_command.Add(new_driving_command);	
      	
      }

      	

      int icp_command_length = cdr.read_type_2();
      data.icp_command = new System.Collections.Generic.List<geometry_msgs.msg.Vector3>(icp_command_length);
      for(int i = 0; i < icp_command_length; i++)
      {
      	geometry_msgs.msg.Vector3 new_icp_command = geometry_msgs.msg.Vector3PubSubType.Create(); 
      	geometry_msgs.msg.Vector3PubSubType.read(new_icp_command, cdr);
      	data.icp_command.Add(new_icp_command);	
      	
      }

      	

   }


	public override void Serialize(halodi_msgs.msg.WholeBodyControllerCommand data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.WholeBodyControllerCommand data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.WholeBodyControllerCommand data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.WholeBodyControllerCommand src, halodi_msgs.msg.WholeBodyControllerCommand target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.WholeBodyControllerCommand src, halodi_msgs.msg.WholeBodyControllerCommand target)
    {
    	Copy(src, target);
    }


}


}