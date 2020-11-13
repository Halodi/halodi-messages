using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "ImuMeasurement" defined in "ImuMeasurement.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ImuMeasurement.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ImuMeasurement.idl instead.
*
*/
public class ImuMeasurementPubSubType : Halodi.CDR.TopicDataType<ImuMeasurement>
{
   public override string Name => "halodi_msgs::msg::dds_::ImuMeasurement_";


   
   public override void serialize(halodi_msgs.msg.ImuMeasurement data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.ImuMeasurement data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ImuMeasurement data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ImuMeasurement data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.ImuNamePubSubType.getCdrSerializedSize(data.imu, current_alignment);

      current_alignment += geometry_msgs.msg.QuaternionPubSubType.getCdrSerializedSize(data.orientation, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.angular_velocity, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.linear_acceleration, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.ImuMeasurement data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.ImuNamePubSubType.write(data.imu, cdr);

      geometry_msgs.msg.QuaternionPubSubType.write(data.orientation, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.angular_velocity, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.linear_acceleration, cdr);

   }

   public static void read(halodi_msgs.msg.ImuMeasurement data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.imu = halodi_msgs.msg.ImuNamePubSubType.Create();
      halodi_msgs.msg.ImuNamePubSubType.read(data.imu, cdr);
      	
      data.orientation = geometry_msgs.msg.QuaternionPubSubType.Create();
      geometry_msgs.msg.QuaternionPubSubType.read(data.orientation, cdr);
      	
      data.angular_velocity = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.angular_velocity, cdr);
      	
      data.linear_acceleration = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.linear_acceleration, cdr);
      	

   }


    public static void Copy(halodi_msgs.msg.ImuMeasurement src, halodi_msgs.msg.ImuMeasurement target)
    {
        target.Set(src);
    }


}


}