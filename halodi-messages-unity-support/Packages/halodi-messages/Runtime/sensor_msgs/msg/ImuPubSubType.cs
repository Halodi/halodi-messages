using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "Imu" defined in "Imu.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Imu.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Imu.idl instead.
*
*/
public class ImuPubSubType : Halodi.CDR.TopicDataType<Imu>
{
   public override string Name => "sensor_msgs::msg::dds_::Imu_";


   public static int getCdrSerializedSize(sensor_msgs.msg.Imu data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Imu data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.QuaternionPubSubType.getCdrSerializedSize(data.orientation, current_alignment);

      current_alignment += ((9) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);
      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.angular_velocity, current_alignment);

      current_alignment += ((9) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);
      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.linear_acceleration, current_alignment);

      current_alignment += ((9) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);

      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.Imu data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.QuaternionPubSubType.write(data.orientation, cdr);

      for(int i0 = 0; i0 < 9; ++i0)
      {
        	cdr.write_type_6(data.orientation_covariance[i0]);	
      }

      geometry_msgs.msg.Vector3PubSubType.write(data.angular_velocity, cdr);

      for(int i0 = 0; i0 < 9; ++i0)
      {
        	cdr.write_type_6(data.angular_velocity_covariance[i0]);	
      }

      geometry_msgs.msg.Vector3PubSubType.write(data.linear_acceleration, cdr);

      for(int i0 = 0; i0 < 9; ++i0)
      {
        	cdr.write_type_6(data.linear_acceleration_covariance[i0]);	
      }

   }

   public static void read(sensor_msgs.msg.Imu data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.orientation = geometry_msgs.msg.QuaternionPubSubType.Create();
      geometry_msgs.msg.QuaternionPubSubType.read(data.orientation, cdr);
      	
      for(int i0 = 0; i0 < 9; ++i0)
      {
        	data.orientation_covariance[i0] = cdr.read_type_6();
        	
      }
      	
      data.angular_velocity = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.angular_velocity, cdr);
      	
      for(int i0 = 0; i0 < 9; ++i0)
      {
        	data.angular_velocity_covariance[i0] = cdr.read_type_6();
        	
      }
      	
      data.linear_acceleration = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.linear_acceleration, cdr);
      	
      for(int i0 = 0; i0 < 9; ++i0)
      {
        	data.linear_acceleration_covariance[i0] = cdr.read_type_6();
        	
      }
      	

   }


	public override void Serialize(sensor_msgs.msg.Imu data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.Imu data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.Imu data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.Imu src, sensor_msgs.msg.Imu target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.Imu src, sensor_msgs.msg.Imu target)
    {
    	Copy(src, target);
    }


}


}