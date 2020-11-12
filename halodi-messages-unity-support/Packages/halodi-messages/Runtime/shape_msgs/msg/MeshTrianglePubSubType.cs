using System.IO;
namespace shape_msgs.msg
{

/**
* 
* Topic data type of the struct "MeshTriangle" defined in "MeshTriangle.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MeshTriangle.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MeshTriangle.idl instead.
*
*/
public class MeshTrianglePubSubType : Halodi.CDR.TopicDataType<shape_msgs.msg.MeshTriangle>
{
   public override string Name => "shape_msgs::msg::dds_::MeshTriangle_";


   
   public override void serialize(shape_msgs.msg.MeshTriangle data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, shape_msgs.msg.MeshTriangle data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(shape_msgs.msg.MeshTriangle data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(shape_msgs.msg.MeshTriangle data, int current_alignment)
   {
      int initial_alignment = current_alignment;


      return current_alignment - initial_alignment;
   }

   public static void write(shape_msgs.msg.MeshTriangle data, Halodi.CDR.CDRSerializer cdr)
   {
   }

   public static void read(shape_msgs.msg.MeshTriangle data, Halodi.CDR.CDRDeserializer cdr)
   {
   }


    public static void Copy(shape_msgs.msg.MeshTriangle src, shape_msgs.msg.MeshTriangle target)
    {
        target.Set(src);
    }


}


}