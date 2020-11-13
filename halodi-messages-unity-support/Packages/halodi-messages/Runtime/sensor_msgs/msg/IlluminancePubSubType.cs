using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "Illuminance" defined in "Illuminance.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Illuminance.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Illuminance.idl instead.
*
*/
public class IlluminancePubSubType : Halodi.CDR.TopicDataType<Illuminance>
{
   public override string Name => "sensor_msgs::msg::dds_::Illuminance_";


   
   public override void serialize(sensor_msgs.msg.Illuminance data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.Illuminance data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Illuminance data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Illuminance data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.Illuminance data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_6(data.illuminance);

      cdr.write_type_6(data.variance);

   }

   public static void read(sensor_msgs.msg.Illuminance data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.illuminance=cdr.read_type_6();
      	
      data.variance=cdr.read_type_6();
      	

   }


    public static void Copy(sensor_msgs.msg.Illuminance src, sensor_msgs.msg.Illuminance target)
    {
        target.Set(src);
    }


}


}