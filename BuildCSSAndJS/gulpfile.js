var gulp = require('gulp');
var cssnano = require('gulp-cssnano');
var sass = require('gulp-sass');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var autoprefix = require('gulp-autoprefixer');
var minifyCSS = require('gulp-minify-css');
var rename = require('gulp-rename');

gulp.task('sass',function(){
	return gulp.src('Source/Styles/**/*.scss')
			.pipe(sass())
      		.pipe(cssnano())
      		.pipe(minifyCSS())
      		.pipe(rename({
	            suffix: '.min'
	        }))
      		.pipe(gulp.dest('../dist/css'));
});