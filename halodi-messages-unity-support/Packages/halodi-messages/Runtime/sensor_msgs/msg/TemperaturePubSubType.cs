using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "Temperature" defined in "Temperature.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Temperature.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Temperature.idl instead.
*
*/
public class TemperaturePubSubType : Halodi.CDR.TopicDataType<sensor_msgs.msg.Temperature>
{
   public override string Name => "sensor_msgs::msg::dds_::Temperature_";


   
   public override void serialize(sensor_msgs.msg.Temperature data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.Temperature data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Temperature data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Temperature data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.Temperature data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_6(data.temperature);

      cdr.write_type_6(data.variance);

   }

   public static void read(sensor_msgs.msg.Temperature data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.temperature=cdr.read_type_6();
      	
      data.variance=cdr.read_type_6();
      	

   }


    public static void Copy(sensor_msgs.msg.Temperature src, sensor_msgs.msg.Temperature target)
    {
        target.Set(src);
    }


}


}