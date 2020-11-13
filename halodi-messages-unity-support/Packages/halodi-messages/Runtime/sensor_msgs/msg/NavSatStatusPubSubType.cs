using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "NavSatStatus" defined in "NavSatStatus.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from NavSatStatus.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit NavSatStatus.idl instead.
*
*/
public class NavSatStatusPubSubType : Halodi.CDR.TopicDataType<NavSatStatus>
{
   public override string Name => "sensor_msgs::msg::dds_::NavSatStatus_";


   
   public override void serialize(sensor_msgs.msg.NavSatStatus data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.NavSatStatus data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.NavSatStatus data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.NavSatStatus data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 2 + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.NavSatStatus data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.status);

      cdr.write_type_3(data.service);

   }

   public static void read(sensor_msgs.msg.NavSatStatus data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.status=cdr.read_type_9();
      	
      data.service=cdr.read_type_3();
      	

   }


    public static void Copy(sensor_msgs.msg.NavSatStatus src, sensor_msgs.msg.NavSatStatus target)
    {
        target.Set(src);
    }


}


}