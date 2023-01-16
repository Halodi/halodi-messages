using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "JointSpaceCommand" defined in "JointSpaceCommand.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JointSpaceCommand.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JointSpaceCommand.idl instead.
*
*/
public class JointSpaceCommandPubSubType : Halodi.CDR.TopicDataType<JointSpaceCommand>
{
   public override string Name => "halodi_msgs::msg::dds_::JointSpaceCommand_";


   public static int getCdrSerializedSize(halodi_msgs.msg.JointSpaceCommand data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointSpaceCommand data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.JointNamePubSubType.getCdrSerializedSize(data.joint, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.JointSpaceCommand data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.JointNamePubSubType.write(data.joint, cdr);

      cdr.write_type_6(data.q_desired);

      cdr.write_type_6(data.qd_desired);

      cdr.write_type_6(data.qdd_desired);

      cdr.write_type_7(data.use_default_gains);

      cdr.write_type_6(data.stiffness);

      cdr.write_type_6(data.damping);

      cdr.write_type_6(data.motorDampingScale);

      cdr.write_type_6(data.max_feedback);

   }

   public static void read(halodi_msgs.msg.JointSpaceCommand data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.joint = halodi_msgs.msg.JointNamePubSubType.Create();
      halodi_msgs.msg.JointNamePubSubType.read(data.joint, cdr);
      	
      data.q_desired=cdr.read_type_6();
      	
      data.qd_desired=cdr.read_type_6();
      	
      data.qdd_desired=cdr.read_type_6();
      	
      data.use_default_gains=cdr.read_type_7();
      	
      data.stiffness=cdr.read_type_6();
      	
      data.damping=cdr.read_type_6();
      	
      data.motorDampingScale=cdr.read_type_6();
      	
      data.max_feedback=cdr.read_type_6();
      	

   }


	public override void Serialize(halodi_msgs.msg.JointSpaceCommand data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.JointSpaceCommand data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.JointSpaceCommand data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.JointSpaceCommand src, halodi_msgs.msg.JointSpaceCommand target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.JointSpaceCommand src, halodi_msgs.msg.JointSpaceCommand target)
    {
    	Copy(src, target);
    }


}


}