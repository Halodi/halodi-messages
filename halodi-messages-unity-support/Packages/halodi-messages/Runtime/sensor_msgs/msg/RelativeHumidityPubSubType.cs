using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "RelativeHumidity" defined in "RelativeHumidity.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from RelativeHumidity.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit RelativeHumidity.idl instead.
*
*/
public class RelativeHumidityPubSubType : Halodi.CDR.TopicDataType<RelativeHumidity>
{
   public override string Name => "sensor_msgs::msg::dds_::RelativeHumidity_";


   public static int getCdrSerializedSize(sensor_msgs.msg.RelativeHumidity data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.RelativeHumidity data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.RelativeHumidity data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_6(data.relative_humidity);

      cdr.write_type_6(data.variance);

   }

   public static void read(sensor_msgs.msg.RelativeHumidity data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.relative_humidity=cdr.read_type_6();
      	
      data.variance=cdr.read_type_6();
      	

   }


	public override void Serialize(sensor_msgs.msg.RelativeHumidity data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.RelativeHumidity data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.RelativeHumidity data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.RelativeHumidity src, sensor_msgs.msg.RelativeHumidity target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.RelativeHumidity src, sensor_msgs.msg.RelativeHumidity target)
    {
    	Copy(src, target);
    }


}


}