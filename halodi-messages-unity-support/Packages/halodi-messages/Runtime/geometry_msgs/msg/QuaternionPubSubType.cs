using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Quaternion" defined in "Quaternion.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Quaternion.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Quaternion.idl instead.
*
*/
public class QuaternionPubSubType : Halodi.CDR.TopicDataType<Quaternion>
{
   public override string Name => "geometry_msgs::msg::dds_::Quaternion_";


   
   public override void serialize(geometry_msgs.msg.Quaternion data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry_msgs.msg.Quaternion data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Quaternion data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Quaternion data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Quaternion data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.x);

      cdr.write_type_6(data.y);

      cdr.write_type_6(data.z);

      cdr.write_type_6(data.w);

   }

   public static void read(geometry_msgs.msg.Quaternion data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.x=cdr.read_type_6();
      	
      data.y=cdr.read_type_6();
      	
      data.z=cdr.read_type_6();
      	
      data.w=cdr.read_type_6();
      	

   }


    public static void Copy(geometry_msgs.msg.Quaternion src, geometry_msgs.msg.Quaternion target)
    {
        target.Set(src);
    }


}


}