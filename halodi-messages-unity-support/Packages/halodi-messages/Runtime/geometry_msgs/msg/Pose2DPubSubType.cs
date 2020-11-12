using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Pose2D" defined in "Pose2D.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Pose2D.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Pose2D.idl instead.
*
*/
public class Pose2DPubSubType : Halodi.CDR.TopicDataType<geometry_msgs.msg.Pose2D>
{
   public override string Name => "geometry_msgs::msg::dds_::Pose2D_";


   
   public override void serialize(geometry_msgs.msg.Pose2D data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry_msgs.msg.Pose2D data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Pose2D data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Pose2D data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Pose2D data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.x);

      cdr.write_type_6(data.y);

      cdr.write_type_6(data.theta);

   }

   public static void read(geometry_msgs.msg.Pose2D data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.x=cdr.read_type_6();
      	
      data.y=cdr.read_type_6();
      	
      data.theta=cdr.read_type_6();
      	

   }


    public static void Copy(geometry_msgs.msg.Pose2D src, geometry_msgs.msg.Pose2D target)
    {
        target.Set(src);
    }


}


}