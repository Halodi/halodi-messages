using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "MagneticField" defined in "MagneticField.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MagneticField.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MagneticField.idl instead.
*
*/
public class MagneticFieldPubSubType : Halodi.CDR.TopicDataType<MagneticField>
{
   public override string Name => "sensor_msgs::msg::dds_::MagneticField_";


   public static int getCdrSerializedSize(sensor_msgs.msg.MagneticField data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.MagneticField data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.magnetic_field, current_alignment);

      current_alignment += ((9) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);

      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.MagneticField data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.magnetic_field, cdr);

      for(int i0 = 0; i0 < 9; ++i0)
      {
        	cdr.write_type_6(data.magnetic_field_covariance[i0]);	
      }

   }

   public static void read(sensor_msgs.msg.MagneticField data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.magnetic_field = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.magnetic_field, cdr);
      	
      for(int i0 = 0; i0 < 9; ++i0)
      {
        	data.magnetic_field_covariance[i0] = cdr.read_type_6();
        	
      }
      	

   }


	public override void Serialize(sensor_msgs.msg.MagneticField data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.MagneticField data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.MagneticField data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.MagneticField src, sensor_msgs.msg.MagneticField target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.MagneticField src, sensor_msgs.msg.MagneticField target)
    {
    	Copy(src, target);
    }


}


}