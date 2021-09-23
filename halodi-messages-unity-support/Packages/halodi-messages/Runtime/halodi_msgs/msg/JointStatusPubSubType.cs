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


   
   public override void serialize(halodi_msgs.msg.JointStatus data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.JointStatus data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointStatus data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointStatus data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.JointNamePubSubType.getCdrSerializedSize(data.joint, current_alignment);

      current_alignment += halodi_msgs.msg.RobotStatusLevelPubSubType.getCdrSerializedSize(data.status_level, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.JointStatus data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.JointNamePubSubType.write(data.joint, cdr);

      halodi_msgs.msg.RobotStatusLevelPubSubType.write(data.status_level, cdr);

      cdr.write_type_7(data.critical_for_balance);

      cdr.write_type_7(data.output_encoder_fault);

      cdr.write_type_7(data.tension_ropes);

   }

   public static void read(halodi_msgs.msg.JointStatus data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.joint = halodi_msgs.msg.JointNamePubSubType.Create();
      halodi_msgs.msg.JointNamePubSubType.read(data.joint, cdr);
      	
      data.status_level = halodi_msgs.msg.RobotStatusLevelPubSubType.Create();
      halodi_msgs.msg.RobotStatusLevelPubSubType.read(data.status_level, cdr);
      	
      data.critical_for_balance=cdr.read_type_7();
      	
      data.output_encoder_fault=cdr.read_type_7();
      	
      data.tension_ropes=cdr.read_type_7();
      	

   }


    public static void Copy(halodi_msgs.msg.JointStatus src, halodi_msgs.msg.JointStatus target)
    {
        target.Set(src);
    }


}


}