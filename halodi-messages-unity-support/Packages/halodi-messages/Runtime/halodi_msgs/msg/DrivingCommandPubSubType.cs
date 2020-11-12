using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "DrivingCommand" defined in "DrivingCommand.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from DrivingCommand.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit DrivingCommand.idl instead.
*
*/
public class DrivingCommandPubSubType : Halodi.CDR.TopicDataType<halodi_msgs.msg.DrivingCommand>
{
   public override string Name => "halodi_msgs::msg::dds_::DrivingCommand_";


   
   public override void serialize(halodi_msgs.msg.DrivingCommand data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.DrivingCommand data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.DrivingCommand data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.DrivingCommand data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.DrivingCommand data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_7(data.filter_driving_commmand);

      cdr.write_type_6(data.linear_velocity);

      cdr.write_type_6(data.angular_velocity);

   }

   public static void read(halodi_msgs.msg.DrivingCommand data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.filter_driving_commmand=cdr.read_type_7();
      	
      data.linear_velocity=cdr.read_type_6();
      	
      data.angular_velocity=cdr.read_type_6();
      	

   }


    public static void Copy(halodi_msgs.msg.DrivingCommand src, halodi_msgs.msg.DrivingCommand target)
    {
        target.Set(src);
    }


}


}