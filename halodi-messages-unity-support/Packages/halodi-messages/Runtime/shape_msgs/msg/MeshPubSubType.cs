using System.IO;
namespace shape_msgs.msg
{

/**
* 
* Topic data type of the struct "Mesh" defined in "Mesh.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Mesh.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Mesh.idl instead.
*
*/
public class MeshPubSubType : Halodi.CDR.TopicDataType<Mesh>
{
   public override string Name => "shape_msgs::msg::dds_::Mesh_";


   
   public override void serialize(shape_msgs.msg.Mesh data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, shape_msgs.msg.Mesh data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(shape_msgs.msg.Mesh data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(shape_msgs.msg.Mesh data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.triangles.Count; ++i0)
      {
          current_alignment += shape_msgs.msg.MeshTrianglePubSubType.getCdrSerializedSize(data.triangles[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.vertices.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.PointPubSubType.getCdrSerializedSize(data.vertices[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(shape_msgs.msg.Mesh data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.triangles == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int triangles_length = data.triangles.Count;
            cdr.write_type_2(triangles_length);
            for (int i0 = 0; i0 < triangles_length; i0++)
            {
      			shape_msgs.msg.MeshTrianglePubSubType.write(data.triangles[i0], cdr);	      }
        }
      	if(data.vertices == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int vertices_length = data.vertices.Count;
            cdr.write_type_2(vertices_length);
            for (int i0 = 0; i0 < vertices_length; i0++)
            {
      			geometry_msgs.msg.PointPubSubType.write(data.vertices[i0], cdr);	      }
        }
   }

   public static void read(shape_msgs.msg.Mesh data, Halodi.CDR.CDRDeserializer cdr)
   {

      int triangles_length = cdr.read_type_2();
      data.triangles = new System.Collections.Generic.List<shape_msgs.msg.MeshTriangle>(triangles_length);
      for(int i = 0; i < triangles_length; i++)
      {
      	shape_msgs.msg.MeshTriangle new_triangles = shape_msgs.msg.MeshTrianglePubSubType.Create(); 
      	shape_msgs.msg.MeshTrianglePubSubType.read(new_triangles, cdr);
      	data.triangles.Add(new_triangles);	
      	
      }

      	

      int vertices_length = cdr.read_type_2();
      data.vertices = new System.Collections.Generic.List<geometry_msgs.msg.Point>(vertices_length);
      for(int i = 0; i < vertices_length; i++)
      {
      	geometry_msgs.msg.Point new_vertices = geometry_msgs.msg.PointPubSubType.Create(); 
      	geometry_msgs.msg.PointPubSubType.read(new_vertices, cdr);
      	data.vertices.Add(new_vertices);	
      	
      }

      	

   }


    public static void Copy(shape_msgs.msg.Mesh src, shape_msgs.msg.Mesh target)
    {
        target.Set(src);
    }


}


}