// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:srv/GetStampedTF.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/srv/get_stamped_tf__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>

// Include directives for member types
// Member `parent_frame`
// Member `child_frame`
#include "rosidl_generator_c/string_functions.h"

bool
halodi_msgs__srv__GetStampedTF_Request__init(halodi_msgs__srv__GetStampedTF_Request * msg)
{
  if (!msg) {
    return false;
  }
  // monotonic_stamp
  // parent_frame
  if (!rosidl_generator_c__String__init(&msg->parent_frame)) {
    halodi_msgs__srv__GetStampedTF_Request__fini(msg);
    return false;
  }
  // child_frame
  if (!rosidl_generator_c__String__init(&msg->child_frame)) {
    halodi_msgs__srv__GetStampedTF_Request__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__srv__GetStampedTF_Request__fini(halodi_msgs__srv__GetStampedTF_Request * msg)
{
  if (!msg) {
    return;
  }
  // monotonic_stamp
  // parent_frame
  rosidl_generator_c__String__fini(&msg->parent_frame);
  // child_frame
  rosidl_generator_c__String__fini(&msg->child_frame);
}

halodi_msgs__srv__GetStampedTF_Request *
halodi_msgs__srv__GetStampedTF_Request__create()
{
  halodi_msgs__srv__GetStampedTF_Request * msg = (halodi_msgs__srv__GetStampedTF_Request *)malloc(sizeof(halodi_msgs__srv__GetStampedTF_Request));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__srv__GetStampedTF_Request));
  bool success = halodi_msgs__srv__GetStampedTF_Request__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__srv__GetStampedTF_Request__destroy(halodi_msgs__srv__GetStampedTF_Request * msg)
{
  if (msg) {
    halodi_msgs__srv__GetStampedTF_Request__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__srv__GetStampedTF_Request__Sequence__init(halodi_msgs__srv__GetStampedTF_Request__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__srv__GetStampedTF_Request * data = NULL;
  if (size) {
    data = (halodi_msgs__srv__GetStampedTF_Request *)calloc(size, sizeof(halodi_msgs__srv__GetStampedTF_Request));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__srv__GetStampedTF_Request__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__srv__GetStampedTF_Request__fini(&data[i - 1]);
      }
      free(data);
      return false;
    }
  }
  array->data = data;
  array->size = size;
  array->capacity = size;
  return true;
}

void
halodi_msgs__srv__GetStampedTF_Request__Sequence__fini(halodi_msgs__srv__GetStampedTF_Request__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__srv__GetStampedTF_Request__fini(&array->data[i]);
    }
    free(array->data);
    array->data = NULL;
    array->size = 0;
    array->capacity = 0;
  } else {
    // ensure that data, size, and capacity values are consistent
    assert(0 == array->size);
    assert(0 == array->capacity);
  }
}

halodi_msgs__srv__GetStampedTF_Request__Sequence *
halodi_msgs__srv__GetStampedTF_Request__Sequence__create(size_t size)
{
  halodi_msgs__srv__GetStampedTF_Request__Sequence * array = (halodi_msgs__srv__GetStampedTF_Request__Sequence *)malloc(sizeof(halodi_msgs__srv__GetStampedTF_Request__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__srv__GetStampedTF_Request__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__srv__GetStampedTF_Request__Sequence__destroy(halodi_msgs__srv__GetStampedTF_Request__Sequence * array)
{
  if (array) {
    halodi_msgs__srv__GetStampedTF_Request__Sequence__fini(array);
  }
  free(array);
}


// Include directives for member types
// Member `stf`
#include "geometry_msgs/msg/transform_stamped__functions.h"

bool
halodi_msgs__srv__GetStampedTF_Response__init(halodi_msgs__srv__GetStampedTF_Response * msg)
{
  if (!msg) {
    return false;
  }
  // ok
  // stf
  if (!geometry_msgs__msg__TransformStamped__init(&msg->stf)) {
    halodi_msgs__srv__GetStampedTF_Response__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__srv__GetStampedTF_Response__fini(halodi_msgs__srv__GetStampedTF_Response * msg)
{
  if (!msg) {
    return;
  }
  // ok
  // stf
  geometry_msgs__msg__TransformStamped__fini(&msg->stf);
}

halodi_msgs__srv__GetStampedTF_Response *
halodi_msgs__srv__GetStampedTF_Response__create()
{
  halodi_msgs__srv__GetStampedTF_Response * msg = (halodi_msgs__srv__GetStampedTF_Response *)malloc(sizeof(halodi_msgs__srv__GetStampedTF_Response));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__srv__GetStampedTF_Response));
  bool success = halodi_msgs__srv__GetStampedTF_Response__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__srv__GetStampedTF_Response__destroy(halodi_msgs__srv__GetStampedTF_Response * msg)
{
  if (msg) {
    halodi_msgs__srv__GetStampedTF_Response__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__srv__GetStampedTF_Response__Sequence__init(halodi_msgs__srv__GetStampedTF_Response__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__srv__GetStampedTF_Response * data = NULL;
  if (size) {
    data = (halodi_msgs__srv__GetStampedTF_Response *)calloc(size, sizeof(halodi_msgs__srv__GetStampedTF_Response));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__srv__GetStampedTF_Response__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__srv__GetStampedTF_Response__fini(&data[i - 1]);
      }
      free(data);
      return false;
    }
  }
  array->data = data;
  array->size = size;
  array->capacity = size;
  return true;
}

void
halodi_msgs__srv__GetStampedTF_Response__Sequence__fini(halodi_msgs__srv__GetStampedTF_Response__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__srv__GetStampedTF_Response__fini(&array->data[i]);
    }
    free(array->data);
    array->data = NULL;
    array->size = 0;
    array->capacity = 0;
  } else {
    // ensure that data, size, and capacity values are consistent
    assert(0 == array->size);
    assert(0 == array->capacity);
  }
}

halodi_msgs__srv__GetStampedTF_Response__Sequence *
halodi_msgs__srv__GetStampedTF_Response__Sequence__create(size_t size)
{
  halodi_msgs__srv__GetStampedTF_Response__Sequence * array = (halodi_msgs__srv__GetStampedTF_Response__Sequence *)malloc(sizeof(halodi_msgs__srv__GetStampedTF_Response__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__srv__GetStampedTF_Response__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__srv__GetStampedTF_Response__Sequence__destroy(halodi_msgs__srv__GetStampedTF_Response__Sequence * array)
{
  if (array) {
    halodi_msgs__srv__GetStampedTF_Response__Sequence__fini(array);
  }
  free(array);
}
