// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/FeedbackParameters3D.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__FEEDBACK_PARAMETERS3_D__STRUCT_HPP_
#define HALODI_MSGS__MSG__FEEDBACK_PARAMETERS3_D__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'proportional'
// Member 'integral'
// Member 'derivative'
#include "geometry_msgs/msg/vector3__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__FeedbackParameters3D __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__FeedbackParameters3D __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct FeedbackParameters3D_
{
  using Type = FeedbackParameters3D_<ContainerAllocator>;

  explicit FeedbackParameters3D_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : proportional(_init),
    derivative(_init)
  {
    (void)_init;
  }

  explicit FeedbackParameters3D_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : proportional(_alloc, _init),
    derivative(_alloc, _init)
  {
    (void)_init;
  }

  // field types and members
  using _proportional_type =
    geometry_msgs::msg::Vector3_<ContainerAllocator>;
  _proportional_type proportional;
  using _integral_type =
    rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::Vector3_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<geometry_msgs::msg::Vector3_<ContainerAllocator>>::other>;
  _integral_type integral;
  using _derivative_type =
    geometry_msgs::msg::Vector3_<ContainerAllocator>;
  _derivative_type derivative;
  using _maximum_proportional_error_type =
    rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other>;
  _maximum_proportional_error_type maximum_proportional_error;
  using _maximum_integral_windup_type =
    rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other>;
  _maximum_integral_windup_type maximum_integral_windup;
  using _maximum_derivative_error_type =
    rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other>;
  _maximum_derivative_error_type maximum_derivative_error;
  using _maximum_feedback_type =
    rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other>;
  _maximum_feedback_type maximum_feedback;
  using _maximum_feedback_rate_type =
    rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other>;
  _maximum_feedback_rate_type maximum_feedback_rate;
  using _integral_leakage_type =
    rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other>;
  _integral_leakage_type integral_leakage;

  // setters for named parameter idiom
  Type & set__proportional(
    const geometry_msgs::msg::Vector3_<ContainerAllocator> & _arg)
  {
    this->proportional = _arg;
    return *this;
  }
  Type & set__integral(
    const rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::Vector3_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<geometry_msgs::msg::Vector3_<ContainerAllocator>>::other> & _arg)
  {
    this->integral = _arg;
    return *this;
  }
  Type & set__derivative(
    const geometry_msgs::msg::Vector3_<ContainerAllocator> & _arg)
  {
    this->derivative = _arg;
    return *this;
  }
  Type & set__maximum_proportional_error(
    const rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other> & _arg)
  {
    this->maximum_proportional_error = _arg;
    return *this;
  }
  Type & set__maximum_integral_windup(
    const rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other> & _arg)
  {
    this->maximum_integral_windup = _arg;
    return *this;
  }
  Type & set__maximum_derivative_error(
    const rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other> & _arg)
  {
    this->maximum_derivative_error = _arg;
    return *this;
  }
  Type & set__maximum_feedback(
    const rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other> & _arg)
  {
    this->maximum_feedback = _arg;
    return *this;
  }
  Type & set__maximum_feedback_rate(
    const rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other> & _arg)
  {
    this->maximum_feedback_rate = _arg;
    return *this;
  }
  Type & set__integral_leakage(
    const rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other> & _arg)
  {
    this->integral_leakage = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__FeedbackParameters3D
    std::shared_ptr<halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__FeedbackParameters3D
    std::shared_ptr<halodi_msgs::msg::FeedbackParameters3D_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const FeedbackParameters3D_ & other) const
  {
    if (this->proportional != other.proportional) {
      return false;
    }
    if (this->integral != other.integral) {
      return false;
    }
    if (this->derivative != other.derivative) {
      return false;
    }
    if (this->maximum_proportional_error != other.maximum_proportional_error) {
      return false;
    }
    if (this->maximum_integral_windup != other.maximum_integral_windup) {
      return false;
    }
    if (this->maximum_derivative_error != other.maximum_derivative_error) {
      return false;
    }
    if (this->maximum_feedback != other.maximum_feedback) {
      return false;
    }
    if (this->maximum_feedback_rate != other.maximum_feedback_rate) {
      return false;
    }
    if (this->integral_leakage != other.integral_leakage) {
      return false;
    }
    return true;
  }
  bool operator!=(const FeedbackParameters3D_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct FeedbackParameters3D_

// alias to use template instance with default allocator
using FeedbackParameters3D =
  halodi_msgs::msg::FeedbackParameters3D_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__FEEDBACK_PARAMETERS3_D__STRUCT_HPP_
