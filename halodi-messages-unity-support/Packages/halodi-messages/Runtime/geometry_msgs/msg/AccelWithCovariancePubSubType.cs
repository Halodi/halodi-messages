using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "AccelWithCovariance" defined in "AccelWithCovariance.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from AccelWithCovariance.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit AccelWithCovariance.idl instead.
*
*/
public class AccelWithCovariancePubSubType : Halodi.CDR.TopicDataType<geometry_msgs.msg.AccelWithCovariance>
{
   public override string Name => "geometry_msgs::msg::dds_::AccelWithCovariance_";


   
   public override void serialize(geometry_msgs.msg.AccelWithCovariance data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry_msgs.msg.AccelWithCovariance data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.AccelWithCovariance data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.AccelWithCovariance data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry_msgs.msg.AccelPubSubType.getCdrSerializedSize(data.accel, current_alignment);

      current_alignment += ((36) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);

      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.AccelWithCovariance data, Halodi.CDR.CDRSerializer cdr)
   {
      geometry_msgs.msg.AccelPubSubType.write(data.accel, cdr);

      for(int i0 = 0; i0 < 36; ++i0)
      {
        	cdr.write_type_6(data.covariance[i0]);	
      }

   }

   public static void read(geometry_msgs.msg.AccelWithCovariance data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.accel = geometry_msgs.msg.AccelPubSubType.Create();
      geometry_msgs.msg.AccelPubSubType.read(data.accel, cdr);
      	
      for(int i0 = 0; i0 < 36; ++i0)
      {
        	data.covariance[i0] = cdr.read_type_6();
        	
      }
      	

   }


    public static void Copy(geometry_msgs.msg.AccelWithCovariance src, geometry_msgs.msg.AccelWithCovariance target)
    {
        target.Set(src);
    }


}


}