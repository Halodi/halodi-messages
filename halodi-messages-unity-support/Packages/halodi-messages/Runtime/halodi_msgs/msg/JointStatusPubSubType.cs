using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "JointStatus" defined in "JointStatus.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JointStatus.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JointStatus.idl instead.
*
*/
public class JointStatusPubSubType : Halodi.CDR.TopicDataType<JointStatus>
{
   public override string Name => "halodi_msgs::msg::dds_::JointStatus_";


   public static int getCdrSerializedSize(halodi_msgs.msg.JointStatus data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointStatus data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.JointNamePubSubType.getCdrSerializedSize(data.joint, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.JointStatus data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.JointNamePubSubType.write(data.joint, cdr);

      cdr.write_type_9(data.status_level);

      cdr.write_type_7(data.critical_for_balance);

      cdr.write_type_7(data.output_encoder_fault);

      cdr.write_type_7(data.tension_ropes);

   }

   public static void read(halodi_msgs.msg.JointStatus data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.joint = halodi_msgs.msg.JointNamePubSubType.Create();
      halodi_msgs.msg.JointNamePubSubType.read(data.joint, cdr);
      	
      data.status_level=cdr.read_type_9();
      	
      data.critical_for_balance=cdr.read_type_7();
      	
      data.output_encoder_fault=cdr.read_type_7();
      	
      data.tension_ropes=cdr.read_type_7();
      	

   }


	public override void Serialize(halodi_msgs.msg.JointStatus data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.JointStatus data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.JointStatus data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.JointStatus src, halodi_msgs.msg.JointStatus target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.JointStatus src, halodi_msgs.msg.JointStatus target)
    {
    	Copy(src, target);
    }


}


}