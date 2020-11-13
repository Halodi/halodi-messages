using System.IO;
namespace nav_msgs.msg
{

/**
* 
* Topic data type of the struct "Odometry" defined in "Odometry.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Odometry.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Odometry.idl instead.
*
*/
public class OdometryPubSubType : Halodi.CDR.TopicDataType<Odometry>
{
   public override string Name => "nav_msgs::msg::dds_::Odometry_";


   
   public override void serialize(nav_msgs.msg.Odometry data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, nav_msgs.msg.Odometry data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(nav_msgs.msg.Odometry data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(nav_msgs.msg.Odometry data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.child_frame_id.Length + 1;

      current_alignment += geometry_msgs.msg.PoseWithCovariancePubSubType.getCdrSerializedSize(data.pose, current_alignment);

      current_alignment += geometry_msgs.msg.TwistWithCovariancePubSubType.getCdrSerializedSize(data.twist, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(nav_msgs.msg.Odometry data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_d(data.child_frame_id);

      geometry_msgs.msg.PoseWithCovariancePubSubType.write(data.pose, cdr);

      geometry_msgs.msg.TwistWithCovariancePubSubType.write(data.twist, cdr);

   }

   public static void read(nav_msgs.msg.Odometry data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.child_frame_id = cdr.read_type_d();	
      data.pose = geometry_msgs.msg.PoseWithCovariancePubSubType.Create();
      geometry_msgs.msg.PoseWithCovariancePubSubType.read(data.pose, cdr);
      	
      data.twist = geometry_msgs.msg.TwistWithCovariancePubSubType.Create();
      geometry_msgs.msg.TwistWithCovariancePubSubType.read(data.twist, cdr);
      	

   }


    public static void Copy(nav_msgs.msg.Odometry src, nav_msgs.msg.Odometry target)
    {
        target.Set(src);
    }


}


}